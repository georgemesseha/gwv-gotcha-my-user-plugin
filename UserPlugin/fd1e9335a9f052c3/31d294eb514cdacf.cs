
partial class _fd1e9335a9f052c3
{
    // Use this method to initialize the state of the child subflow to provide
    // the initial data to work on.
    public async Task PreExecute_31d294eb514cdacf(_6bc65f3eb1d12e0b subflow)
    {
        subflow.Input("https://www.notion.so/9d397c27567e4490a2d8b98cbe0f4640?v=b4be136bb3004fae8eee39279d619d40&source=copy_link"); // provide the input to the subflow using the input method defined in the subflow
    }
    
    // Use this method to update the parent state with the result of the sub-flow (if needed)
    // before moving forward with the flow
    public async Task PostExecute_31d294eb514cdacf(_6bc65f3eb1d12e0b subflow)
    {
        // The below code is an example using the output of the subflow
        // this.UserName = subflow.ProvidedUserName
    }
}
