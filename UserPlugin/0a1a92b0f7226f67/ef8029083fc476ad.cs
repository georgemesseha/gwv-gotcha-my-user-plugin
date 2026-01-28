
partial class _0a1a92b0f7226f67
{
    // Use this method to initialize the state of the child subflow to provide
    // the initial data to work on.
    public async Task PreExecute_ef8029083fc476ad(_f37840b0923e975e subflow)
    {
        subflow.Input("Notion", "https://www.notion.so/Tasks-e180470b73314986ad21b98d61b877be?source=copy_link", false);
    }
    
    // Use this method to update the parent state with the result of the sub-flow (if needed)
    // before moving forward with the flow
    public async Task PostExecute_ef8029083fc476ad(_f37840b0923e975e subflow)
    {
        // The below code is an example using the output of the subflow
        // this.UserName = subflow.ProvidedUserName
    }
}
