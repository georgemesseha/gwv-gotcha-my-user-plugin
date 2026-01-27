
partial class _210de7050ecbbe0d
{
    // Use this method to initialize the state of the child subflow to provide
    // the initial data to work on.
    public async Task PreExecute_cb3160808e8f1cbb(_badeecd3b585dc48 subflow)
    {
        subflow.Input(this.ProcessName);
    }
    
    // Use this method to update the parent state with the result of the sub-flow (if needed)
    // before moving forward with the flow
    public async Task PostExecute_cb3160808e8f1cbb(_badeecd3b585dc48 subflow)
    {
        // The below code is an example using the output of the subflow
        // this.UserName = subflow.ProvidedUserName
    }
}
