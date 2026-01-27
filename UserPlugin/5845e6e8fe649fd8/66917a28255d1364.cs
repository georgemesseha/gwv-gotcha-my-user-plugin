
using System.Diagnostics;

partial class _5845e6e8fe649fd8
{
    public async Task<int> _66917a28255d1364()
    {
        CommitAndPush(@"D:\Projects\gwv.Gotcha\gwv.Gotcha.Wpf\bin\Debug\net8.0-windows\__USER_PLUGIN__");
       return 0; // return the output port index according to your logic
    }

    public static void CommitAndPush(string workingDir)
    {
        // Change to the working directory
        var processStartInfo = new ProcessStartInfo
        {
            FileName = "git",
            Arguments = "add .",
            WorkingDirectory = workingDir,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        using (var process = Process.Start(processStartInfo))
        {
            process.WaitForExit();
            if (process.ExitCode != 0)
            {
                throw new Exception($"Git add failed: {process.StandardError.ReadToEnd()}");
            }
        }

        // Commit with a default message
        processStartInfo.Arguments = "commit -m \"Auto commit\"";
        using (var process = Process.Start(processStartInfo))
        {
            process.WaitForExit();
            if (process.ExitCode != 0)
            {
                var error = process.StandardError.ReadToEnd();
                if (!error.Contains("nothing to commit"))
                {
                    throw new Exception($"Git commit failed: {error}");
                }
            }
        }

        // Push
        processStartInfo.Arguments = "push";
        using (var process = Process.Start(processStartInfo))
        {
            process.WaitForExit();
            if (process.ExitCode != 0)
            {
                throw new Exception($"Git push failed: {process.StandardError.ReadToEnd()}");
            }
        }
    }
}
