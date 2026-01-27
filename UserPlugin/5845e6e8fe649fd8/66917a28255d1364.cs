using System.Diagnostics;

partial class _5845e6e8fe649fd8
{
    public async Task<int> _66917a28255d1364()
    {
       bool result = CommitAndPush(@"D:\Projects\gwv.Gotcha\gwv.Gotcha.Wpf\bin\Debug\net8.0-windows\__USER_PLUGIN__");
       return 1;
       return result ? 0 : 1; // return the output port index according to your logic
    }

    public bool CommitAndPush(string workingDir)
    {
        try
        {
            // Run all git commands in a visible console and keep it open
            var processStartInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = $"/c cd /d \"{workingDir}\" && echo Starting git operations... && (git status --porcelain | findstr . >nul && (git add . && git commit -m \"Auto commit\" && git push) || echo No changes to commit) && echo Git operations completed. && echo Press any key to close... && pause >nul",
                UseShellExecute = false,
                CreateNoWindow = false
            };

            using (var process = Process.Start(processStartInfo))
            {
                process.WaitForExit();
                // Treat STATUS_CONTROL_C_EXIT (-1073741510) as success since user dismissed the window
                if (process.ExitCode != 0 && process.ExitCode != -1073741510)
                {
                    throw new Exception($"Git operations failed with exit code {process.ExitCode}");
                }
            }
            return true;
        }
        catch (Exception ex)
        {
            _srv.Clipboard.SetText(ex.ToString());
            _srv.TextToSpeech.Speak("Running git commands failed. Error details have been copied to clipboard.");
            return false;
        }
        
    }
}
