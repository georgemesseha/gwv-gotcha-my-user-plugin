
partial class _3fe642069f5f8492
{
    // Use this method to initialize the state of the child subflow to provide
    // the initial data to work on.
    public async Task PreExecute_c796ed902f6d2f55(_e027685ebc6e189f subflow)
    {
        // The sample code below assumes that you got a custom SetInitialState
        // in the subflow type.
        // subflow.SetInitialState(arg1, arg2);
    }
    
    // Use this method to update the parent state with the result of the sub-flow (if needed)
    // before moving forward with the flow
    public async Task PostExecute_c796ed902f6d2f55(_e027685ebc6e189f subflow)
    {
        // The below code is an example using the output of the subflow
        // this.UserName = subflow.ProvidedUserName
    }
}
