
partial class _2a4ca6049d860ca7
{
    // Use this method to initialize the state of the child subflow to provide
    // the initial data to work on.
    public async Task PreExecute_9f120fc770fc51ce(_f0e3d3f2b8d18521 subflow)
    {
        // The sample code below assumes that you got a custom SetInitialState
        // in the subflow type.
        // subflow.SetInitialState(arg1, arg2);
    }
    
    // Use this method to update the parent state with the result of the sub-flow (if needed)
    // before moving forward with the flow
    public async Task PostExecute_9f120fc770fc51ce(_f0e3d3f2b8d18521 subflow)
    {
        // The below code is an example using the output of the subflow
        // this.UserName = subflow.ProvidedUserName
    }
}
