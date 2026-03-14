
partial class _ca72e41fbc666054
{
    // Use this method to initialize the state of the child subflow to provide
    // the initial data to work on.
    public async Task PreExecute_b75fe4431f8ba3bf(_6bc65f3eb1d12e0b subflow)
    {
        subflow.Input("https://www.notion.so/Tasks-e180470b73314986ad21b98d61b877be?source=copy_link");
    }
    
    // Use this method to update the parent state with the result of the sub-flow (if needed)
    // before moving forward with the flow
    public async Task PostExecute_b75fe4431f8ba3bf(_6bc65f3eb1d12e0b subflow)
    {
        // The below code is an example using the output of the subflow
        // this.UserName = subflow.ProvidedUserName
    }
}
