
partial class _7f14b0a4764e006a
{
    // Use this method to initialize the state of the child subflow to provide
    // the initial data to work on.
    public async Task PreExecute_b31b2b0669f13eb3(_4db71e8135237fe6 subflow)
    {
        // The sample code below assumes that you got a custom SetInitialState
        // in the subflow type.
        // subflow.SetInitialState(arg1, arg2);
    }
    
    // Use this method to update the parent state with the result of the sub-flow (if needed)
    // before moving forward with the flow
    public async Task PostExecute_b31b2b0669f13eb3(_4db71e8135237fe6 subflow)
    {
        // The below code is an example using the output of the subflow
        // this.UserName = subflow.ProvidedUserName
    }
}
