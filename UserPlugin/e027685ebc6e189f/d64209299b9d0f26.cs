
partial class _e027685ebc6e189f
{
    // Use this method to initialize the state of the child subflow to provide
    // the initial data to work on.
    public async Task PreExecute_d64209299b9d0f26(_340b866f63df92b7 subflow)
    {
        subflow.SetInput("https://stg.sahell.ae", "https://stgapi.sahell.ae/api/AccountType/GetAllAccountTypesByLogo?ln=ar-EG");
    }
    
    // Use this method to update the parent state with the result of the sub-flow (if needed)
    // before moving forward with the flow
    public async Task PostExecute_d64209299b9d0f26(_340b866f63df92b7 subflow)
    {
        // The below code is an example using the output of the subflow
        // this.UserName = subflow.ProvidedUserName
    }
}
