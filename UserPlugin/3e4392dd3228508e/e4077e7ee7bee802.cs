
partial class _3e4392dd3228508e
{
    // Use this method to initialize the state of the child subflow to provide
    // the initial data to work on.
    public async Task PreExecute_e4077e7ee7bee802(_b366a645d63b3d5e subflow)
    {
        subflow.Input("https://entra.microsoft.com/#view/Microsoft_AAD_RegisteredApps/AuthenticationV2Blade/appId/87bbfac1-fb60-4730-81fd-00cbae8ca44b/isMSAApp~/false");
    }
    
    // Use this method to update the parent state with the result of the sub-flow (if needed)
    // before moving forward with the flow
    public async Task PostExecute_e4077e7ee7bee802(_b366a645d63b3d5e subflow)
    {
        // The below code is an example using the output of the subflow
        // this.UserName = subflow.ProvidedUserName
    }
}
