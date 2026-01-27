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
        // Run all git commands in a visible console and keep it open
        var processStartInfo = new ProcessStartInfo
        {
            FileName = "cmd.exe",
            Arguments = $"/c cd /d \"{workingDir}\" && echo Starting git operations... && git add . && git commit -m \"Auto commit\" && git push && echo Git operations completed. && echo Press any key to close... && pause >nul",
            UseShellExecute = false,
            CreateNoWindow = false
        };

        using (var process = Process.Start(processStartInfo))
        {
            process.WaitForExit();
            if (process.ExitCode != 0)
            {
                throw new Exception("Git operations failed.");
            }
        }
    }
}
