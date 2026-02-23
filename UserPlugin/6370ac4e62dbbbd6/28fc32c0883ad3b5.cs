
partial class _6370ac4e62dbbbd6
{
    // Use this method to initialize the state of the child subflow to provide
    // the initial data to work on.
    public async Task PreExecute_28fc32c0883ad3b5(_b366a645d63b3d5e subflow)
    {
        subflow.Input("https://aistudio.google.com/live?model=gemini-2.5-flash-native-audio-preview-12-2025");
    }
    
    // Use this method to update the parent state with the result of the sub-flow (if needed)
    // before moving forward with the flow
    public async Task PostExecute_28fc32c0883ad3b5(_b366a645d63b3d5e subflow)
    {
        // The below code is an example using the output of the subflow
        // this.UserName = subflow.ProvidedUserName
    }
}
