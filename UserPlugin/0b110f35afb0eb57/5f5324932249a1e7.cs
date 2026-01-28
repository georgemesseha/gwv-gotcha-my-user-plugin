
partial class _0b110f35afb0eb57
{
    // Use this method to initialize the state of the child subflow to provide
    // the initial data to work on.
    public async Task PreExecute_5f5324932249a1e7(_f37840b0923e975e subflow)
    {
        subflow.Input("OneCommander", this.Path);
    }
    
    // Use this method to update the parent state with the result of the sub-flow (if needed)
    // before moving forward with the flow
    public async Task PostExecute_5f5324932249a1e7(_f37840b0923e975e subflow)
    {
        // The below code is an example using the output of the subflow
        // this.UserName = subflow.ProvidedUserName
    }
}
