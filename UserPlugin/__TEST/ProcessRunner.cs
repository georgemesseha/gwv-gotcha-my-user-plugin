using System.Diagnostics;
using System.Text;

namespace YourApp.Processes;

public sealed record CommandRunResult(
    bool Started,
    int? ExitCode,
    Exception? Exception = null);

public interface ICommandRunner
{
    Task<CommandRunResult> RunExecutableAsync(
        string fileName,
        string? arguments = null,
        string? workingDirectory = null,
        string? standardInput = null,
        IReadOnlyDictionary<string, string>? environment = null,
        Action<string>? onStdOut = null,
        Action<string>? onStdErr = null,
        CancellationToken ct = default);

    Task<CommandRunResult> RunCmdAsync(
        string command,
        string? workingDirectory = null,
        string? standardInput = null,
        IReadOnlyDictionary<string, string>? environment = null,
        Action<string>? onStdOut = null,
        Action<string>? onStdErr = null,
        CancellationToken ct = default);

    Task<CommandRunResult> RunPowerShellAsync(
        string command,
        string? workingDirectory = null,
        string? standardInput = null,
        IReadOnlyDictionary<string, string>? environment = null,
        Action<string>? onStdOut = null,
        Action<string>? onStdErr = null,
        CancellationToken ct = default);

    Process? RunCmdInteractive(
        string command,
        string? workingDirectory = null,
        bool keepOpen = true);

    Process? RunPowerShellInteractive(
        string command,
        string? workingDirectory = null,
        bool keepOpen = true);

    void OpenWithDefaultApp(
        string pathOrUrl,
        string? workingDirectory = null);
}

public sealed class CommandRunner : ICommandRunner
{
    public Task<CommandRunResult> RunExecutableAsync(
        string fileName,
        string? arguments = null,
        string? workingDirectory = null,
        string? standardInput = null,
        IReadOnlyDictionary<string, string>? environment = null,
        Action<string>? onStdOut = null,
        Action<string>? onStdErr = null,
        CancellationToken ct = default)
    {
        return RunNonInteractiveAsync(
            CreateExecutableStartInfo(fileName, arguments, workingDirectory, environment),
            standardInput,
            onStdOut,
            onStdErr,
            ct);
    }

    public Task<CommandRunResult> RunCmdAsync(
        string command,
        string? workingDirectory = null,
        string? standardInput = null,
        IReadOnlyDictionary<string, string>? environment = null,
        Action<string>? onStdOut = null,
        Action<string>? onStdErr = null,
        CancellationToken ct = default)
    {
        return RunNonInteractiveAsync(
            CreateCmdStartInfo(command, workingDirectory, environment, interactive: false, keepOpen: false),
            standardInput,
            onStdOut,
            onStdErr,
            ct);
    }

    public Task<CommandRunResult> RunPowerShellAsync(
        string command,
        string? workingDirectory = null,
        string? standardInput = null,
        IReadOnlyDictionary<string, string>? environment = null,
        Action<string>? onStdOut = null,
        Action<string>? onStdErr = null,
        CancellationToken ct = default)
    {
        return RunNonInteractiveAsync(
            CreatePowerShellStartInfo(command, workingDirectory, environment, interactive: false, keepOpen: false),
            standardInput,
            onStdOut,
            onStdErr,
            ct);
    }

    public Process? RunCmdInteractive(
        string command,
        string? workingDirectory = null,
        bool keepOpen = true)
    {
        return Process.Start(CreateCmdStartInfo(
            command,
            workingDirectory,
            environment: null,
            interactive: true,
            keepOpen: keepOpen));
    }

    public Process? RunPowerShellInteractive(
        string command,
        string? workingDirectory = null,
        bool keepOpen = true)
    {
        return Process.Start(CreatePowerShellStartInfo(
            command,
            workingDirectory,
            environment: null,
            interactive: true,
            keepOpen: keepOpen));
    }

    public void OpenWithDefaultApp(
        string pathOrUrl,
        string? workingDirectory = null)
    {
        Process.Start(new ProcessStartInfo
        {
            FileName = pathOrUrl,
            WorkingDirectory = workingDirectory ?? "",
            UseShellExecute = true,
            Verb = "open"
        });
    }

    private static async Task<CommandRunResult> RunNonInteractiveAsync(
        ProcessStartInfo startInfo,
        string? standardInput,
        Action<string>? onStdOut,
        Action<string>? onStdErr,
        CancellationToken ct)
    {
        try
        {
            using var process = new Process
            {
                StartInfo = startInfo,
                EnableRaisingEvents = true
            };

            process.OutputDataReceived += (_, e) =>
            {
                if (e.Data is not null)
                    onStdOut?.Invoke(e.Data);
            };

            process.ErrorDataReceived += (_, e) =>
            {
                if (e.Data is not null)
                    onStdErr?.Invoke(e.Data);
            };

            if (!process.Start())
                return new CommandRunResult(false, null);

            process.BeginOutputReadLine();
            process.BeginErrorReadLine();

            if (!string.IsNullOrEmpty(standardInput))
            {
                await process.StandardInput.WriteAsync(standardInput);
                await process.StandardInput.FlushAsync(ct);
                process.StandardInput.Close();
            }

            await process.WaitForExitAsync(ct);

            return new CommandRunResult(true, process.ExitCode);
        }
        catch (Exception ex)
        {
            return new CommandRunResult(false, null, ex);
        }
    }

    private static ProcessStartInfo CreateExecutableStartInfo(
        string fileName,
        string? arguments,
        string? workingDirectory,
        IReadOnlyDictionary<string, string>? environment)
    {
        return CreateBaseNonInteractiveStartInfo(
            fileName,
            arguments,
            workingDirectory,
            environment);
    }

    private static ProcessStartInfo CreateCmdStartInfo(
        string command,
        string? workingDirectory,
        IReadOnlyDictionary<string, string>? environment,
        bool interactive,
        bool keepOpen)
    {
        var args = interactive
            ? keepOpen ? $"/k {command}" : $"/c {command}"
            : $"/d /s /c \"{command}\"";

        return interactive
            ? CreateBaseInteractiveStartInfo("cmd.exe", args, workingDirectory)
            : CreateBaseNonInteractiveStartInfo("cmd.exe", args, workingDirectory, environment);
    }

    private static ProcessStartInfo CreatePowerShellStartInfo(
        string command,
        string? workingDirectory,
        IReadOnlyDictionary<string, string>? environment,
        bool interactive,
        bool keepOpen)
    {
        var encodedCommand = Convert.ToBase64String(
            Encoding.Unicode.GetBytes(command));

        var keepOpenArg = interactive && keepOpen
            ? "-NoExit "
            : "";

        var args = $"{keepOpenArg}-NoProfile -ExecutionPolicy Bypass -EncodedCommand {encodedCommand}";

        return interactive
            ? CreateBaseInteractiveStartInfo("pwsh.exe", args, workingDirectory)
            : CreateBaseNonInteractiveStartInfo("pwsh.exe", args, workingDirectory, environment);
    }

    private static ProcessStartInfo CreateBaseNonInteractiveStartInfo(
        string fileName,
        string? arguments,
        string? workingDirectory,
        IReadOnlyDictionary<string, string>? environment)
    {
        var psi = new ProcessStartInfo
        {
            FileName = fileName,
            Arguments = arguments ?? "",
            WorkingDirectory = workingDirectory ?? "",
            UseShellExecute = false,

            RedirectStandardOutput = true,
            RedirectStandardError = true,
            RedirectStandardInput = true,

            CreateNoWindow = true,
            WindowStyle = ProcessWindowStyle.Hidden
        };

        if (environment is not null)
        {
            foreach (var pair in environment)
                psi.Environment[pair.Key] = pair.Value;
        }

        return psi;
    }

    private static ProcessStartInfo CreateBaseInteractiveStartInfo(
        string fileName,
        string arguments,
        string? workingDirectory)
    {
        return new ProcessStartInfo
        {
            FileName = fileName,
            Arguments = arguments,
            WorkingDirectory = workingDirectory ?? "",
            UseShellExecute = true,
            CreateNoWindow = false,
            WindowStyle = ProcessWindowStyle.Normal
        };
    }
}