
partial class _aae3150bdd52c103
{
    // Return the question that the user should answer in text
    public async Task<string> GenerateQuestion_e33f6038ce3d7359()
    {
        return "Question to user not set! Alt + Double-click the node to set it in code.";
    }
    
    // Consume the user answer to typically change the state
    public async Task<int> OnAnswerOf_e33f6038ce3d7359(string answer)
    {
        _srv.TextToSpeech.Speak("Replace this with some use of answer provided as argument.");
        return 0;
    }
    
    // This method is invoked first. When returns a value < 0, it implies
    // run normally, don't skip the dialog. Otherwise, the dialog will be
    // skipped to the output port = the value returned.
    public async Task<int> Skip_e33f6038ce3d7359()
    {
        // -1 means don't skip and go normally. Any other value like (x) means skip the dialog and continue to port (x),
        // while x must be an existing port index on the designer.
        return -1; 
    } 
}
