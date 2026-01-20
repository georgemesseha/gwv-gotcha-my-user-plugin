
partial class _ca72e41fbc666054
{
    // Use this method to initialize the state of the child subflow to provide
    // the initial data to work on.
    public async Task PreExecute_96dff8f6847b8b2c(_ae32cea017a88e91 subflow)
    {
        // The sample code below assumes that you got a custom SetInitialState
        // in the subflow type.
        subflow.Input("test", 5);
    }
    
    // Use this method to update the parent state with the result of the sub-flow (if needed)
    // before moving forward with the flow
    public async Task PostExecute_96dff8f6847b8b2c(_ae32cea017a88e91 subflow)
    {
        // The below code is an example using the output of the subflow
        // this.UserName = subflow.ProvidedUserName
    }
}
