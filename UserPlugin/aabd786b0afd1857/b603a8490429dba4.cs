
partial class _aabd786b0afd1857
{
    // Use this method to initialize the state of the child subflow to provide
    // the initial data to work on.
    public async Task PreExecute_b603a8490429dba4(_c4601fbac7a0289f subflow)
    {
        subflow.Input(_nodeRedDirPath);
    }
    
    // Use this method to update the parent state with the result of the sub-flow (if needed)
    // before moving forward with the flow
    public async Task PostExecute_b603a8490429dba4(_c4601fbac7a0289f subflow)
    {
        // The below code is an example using the output of the subflow
        // this.UserName = subflow.ProvidedUserName
    }
}
