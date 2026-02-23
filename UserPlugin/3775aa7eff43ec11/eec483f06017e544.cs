
partial class _3775aa7eff43ec11
{
    // Use this method to initialize the state of the child subflow to provide
    // the initial data to work on.
    public async Task PreExecute_eec483f06017e544(_b366a645d63b3d5e subflow)
    {
        subflow.Input("https://www.notion.so/Entra-ID-Service-to-Service-Scopes-User-Roles-Groups-Authorization-263098a50fa1440a8645c7c814e0e3ab?source=copy_link");
    }
    
    // Use this method to update the parent state with the result of the sub-flow (if needed)
    // before moving forward with the flow
    public async Task PostExecute_eec483f06017e544(_b366a645d63b3d5e subflow)
    {
        // The below code is an example using the output of the subflow
        // this.UserName = subflow.ProvidedUserName
    }
}
