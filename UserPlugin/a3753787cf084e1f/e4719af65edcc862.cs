
partial class _a3753787cf084e1f
{
    // Use this method to initialize the state of the child subflow to provide
    // the initial data to work on.
    public async Task PreExecute_e4719af65edcc862(_b366a645d63b3d5e subflow)
    {
        subflow.Input("https://safecityportal.com");
    }
    
    // Use this method to update the parent state with the result of the sub-flow (if needed)
    // before moving forward with the flow
    public async Task PostExecute_e4719af65edcc862(_b366a645d63b3d5e subflow)
    {
        // The below code is an example using the output of the subflow
        // this.UserName = subflow.ProvidedUserName
    }
}
