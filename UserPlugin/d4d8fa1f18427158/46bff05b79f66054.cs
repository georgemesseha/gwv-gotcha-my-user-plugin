
partial class _d4d8fa1f18427158
{
    // Use this method to initialize the state of the child subflow to provide
    // the initial data to work on.
    public async Task PreExecute_46bff05b79f66054(_b366a645d63b3d5e subflow)
    {
        subflow.Input("https://dev.azure.com/SoftecMEA/SaaedI/_git/saaedi-identity-poc");
    }
    
    // Use this method to update the parent state with the result of the sub-flow (if needed)
    // before moving forward with the flow
    public async Task PostExecute_46bff05b79f66054(_b366a645d63b3d5e subflow)
    {
        // The below code is an example using the output of the subflow
        // this.UserName = subflow.ProvidedUserName
    }
}
