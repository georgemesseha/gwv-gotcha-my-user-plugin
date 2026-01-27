
partial class _f37840b0923e975e
{
    public async Task<int> _7838e8436ad26c8d()
    {
        if(string.IsNullOrWhiteSpace(this.ProcessName))
        {
            _ = _srv.TextToSpeech.Speak("Process Name wasn't prvided.");
            return 1;
        }

        var result =
        await _srv.ProcessRunner.RunGotchaDetectedProcess(this.ProcessName, 
                                                    this.Args,
                                                    this.WorkingDir,
                                                    this.WaitForExit,
                                                    this.ShowWindow);

        if(result.success == false)
        {
            _ = _srv.TextToSpeech.Speak("Failed to start the process " + this.ProcessName + ". ");
            return 1;
        }

       return 0; // return the output port index according to your logic
    }
}
