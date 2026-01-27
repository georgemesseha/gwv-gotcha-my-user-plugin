
partial class _4410d79ded623b29
{
    // Use this method to initialize the state of the child subflow to provide
    // the initial data to work on.
    public async Task PreExecute_0bb9351eaa6660d5(_b366a645d63b3d5e subflow)
    {
        // The sample code below assumes that you got a custom SetInitialState
        // in the subflow type.
        // subflow.SetInitialState(arg1, arg2);
        subflow.Input("https://violinlounge.com/free-online-violin-tuner-with-mic-and-tuning-notes/");
    }
    
    // Use this method to update the parent state with the result of the sub-flow (if needed)
    // before moving forward with the flow
    public async Task PostExecute_0bb9351eaa6660d5(_b366a645d63b3d5e subflow)
    {
        // The below code is an example using the output of the subflow
        // this.UserName = subflow.ProvidedUserName
    }
}
