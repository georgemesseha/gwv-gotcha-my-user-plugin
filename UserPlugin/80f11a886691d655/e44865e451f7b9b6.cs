
partial class _80f11a886691d655
{
    // Use this method to initialize the state of the child subflow to provide
    // the initial data to work on.
    public async Task PreExecute_e44865e451f7b9b6(_f37840b0923e975e subflow)
    {
        subflow.Input("StorageExplorer", "");
    }
    
    // Use this method to update the parent state with the result of the sub-flow (if needed)
    // before moving forward with the flow
    public async Task PostExecute_e44865e451f7b9b6(_f37840b0923e975e subflow)
    {
        // The below code is an example using the output of the subflow
        // this.UserName = subflow.ProvidedUserName
    }
}
