
partial class _c4601fbac7a0289f
{
    public async Task<int> _09d80c2fbcb16468()
    {
        if(string.IsNullOrWhiteSpace(DirPath) && string.IsNullOrWhiteSpace(FilePath))
        {
            _ = _srv.TextToSpeech.Speak("Neither Directory path nor file path wasn provided.");
            return 1;
        }
        if(string.IsNullOrWhiteSpace(DirPath) == false)
        {
            if(Directory.Exists(DirPath) == false)
            {
                _ = _srv.TextToSpeech.Speak("Directory provided doesn't exist.");
                return 1;
            }
        }
        if(string.IsNullOrWhiteSpace(FilePath) == false)
        {
            if(File.Exists(FilePath) == false)
            {
                _ = _srv.TextToSpeech.Speak("File provided doesn't exist.");
                return 1;
            }
        }

        // System.Diagnostics.Process.Start("cmd.exe", "/c code \"" + this.DirPath + "\" \"" + this.FilePath + "\"");
        var psi = new System.Diagnostics.ProcessStartInfo
        {
            FileName = "code",
            Arguments = $"\"{this.DirPath}\" \"{this.FilePath}\"",
            WorkingDirectory = this.DirPath,
            UseShellExecute = true 
        };

        System.Diagnostics.Process.Start(psi);

        return 0; // return the output port index according to your logic
    
    }
}
