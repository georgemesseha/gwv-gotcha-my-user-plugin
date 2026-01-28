
partial class _0a1a92b0f7226f67
{
    // Use this method to initialize the state of the child subflow to provide
    // the initial data to work on.
    public async Task PreExecute_21d20f85ce077253(_d308dbbe2c25074e subflow)
    {
        subflow.Input("https://safecityportal.com/company/personal/user/320/tasks/");
    }
    
    // Use this method to update the parent state with the result of the sub-flow (if needed)
    // before moving forward with the flow
    public async Task PostExecute_21d20f85ce077253(_d308dbbe2c25074e subflow)
    {
        // The below code is an example using the output of the subflow
        // this.UserName = subflow.ProvidedUserName
    }
}
