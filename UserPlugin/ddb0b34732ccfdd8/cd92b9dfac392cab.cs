
partial class _ddb0b34732ccfdd8
{
    // Use this method to initialize the state of the child subflow to provide
    // the initial data to work on.
    public async Task PreExecute_cd92b9dfac392cab(_b366a645d63b3d5e subflow)
    {
        subflow.Input("https://www.notion.so/Saaed-i-2fd6ea6ef60880128260fe82a4338d87");
    }
     
    // Use this method to update the parent state with the result of the sub-flow (if needed)
    // before moving forward with the flow
    public async Task PostExecute_cd92b9dfac392cab(_b366a645d63b3d5e subflow)
    {
        // The below code is an example using the output of the subflow
        // this.UserName = subflow.ProvidedUserName
    }
}
