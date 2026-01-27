
partial class _ab6c892af4f1cd99
{
    public async Task<int> _0505a493d72aef6c()
    {
        if(string.IsNullOrWhiteSpace(DirPath))
        {
            _ = _srv.TextToSpeech.Speak("Directory path wasn't provided.");
            return 1;
        }
        if(Directory.Exists(DirPath) == false)
        {
            _ = _srv.TextToSpeech.Speak("Directory provided doesn't exist.");
            return 1;
        }

        System.Diagnostics.Process.Start("cmd.exe", "/c rider \"" + this.DirPath + "\"");


       return 0; // return the output port index according to your logic
    }
}
