
partial class _3775aa7eff43ec11
{
    // Use this method to initialize the state of the child subflow to provide
    // the initial data to work on.
    public async Task PreExecute_18471feb02145d11(_b366a645d63b3d5e subflow)
    {
        subflow.Input("https://www.notion.so/Saaed-Private-Nuget-Repo-3196ea6ef6088012a25bc9183a3274aa?source=copy_link");
    }
    
    // Use this method to update the parent state with the result of the sub-flow (if needed)
    // before moving forward with the flow
    public async Task PostExecute_18471feb02145d11(_b366a645d63b3d5e subflow)
    {
        // The below code is an example using the output of the subflow
        // this.UserName = subflow.ProvidedUserName
    }
}
