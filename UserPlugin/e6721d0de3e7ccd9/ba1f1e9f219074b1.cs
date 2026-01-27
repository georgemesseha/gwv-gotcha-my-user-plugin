
partial class _e6721d0de3e7ccd9
{
    // Use this method to initialize the state of the child subflow to provide
    // the initial data to work on.
    public async Task PreExecute_ba1f1e9f219074b1(_b366a645d63b3d5e subflow)
    {
        subflow.Input("https://sahel-dev.20.233.204.79.sslip.io/");
    }
    
    // Use this method to update the parent state with the result of the sub-flow (if needed)
    // before moving forward with the flow
    public async Task PostExecute_ba1f1e9f219074b1(_b366a645d63b3d5e subflow)
    {
        // The below code is an example using the output of the subflow
        // this.UserName = subflow.ProvidedUserName
    }
}
