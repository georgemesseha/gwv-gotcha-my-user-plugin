
partial class _3775aa7eff43ec11
{
    // Use this method to initialize the state of the child subflow to provide
    // the initial data to work on.
    public async Task PreExecute_309545a64541120d(_b366a645d63b3d5e subflow)
    {
        subflow.Input("https://dev.azure.com/SoftecMEA/SaaedI/_git/SaaedAuth");
    }
    
    // Use this method to update the parent state with the result of the sub-flow (if needed)
    // before moving forward with the flow
    public async Task PostExecute_309545a64541120d(_b366a645d63b3d5e subflow)
    {
        // The below code is an example using the output of the subflow
        // this.UserName = subflow.ProvidedUserName
    }
}
