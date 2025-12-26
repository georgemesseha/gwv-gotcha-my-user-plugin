
partial class _e6721d0de3e7ccd9
{
    // Use this method to initialize the state of the child subflow to provide
    // the initial data to work on.
    public async Task PreExecute_a0d81457c1d1837a(_b366a645d63b3d5e subflow)
    {
        subflow.Url = "https://sahel-dev.20.233.204.79.sslip.io/api/ServiceCategory/GetAllServicesCategoriesWithServices?ln=ar-EG";
        
        // The sample code below assumes that you got a custom SetInitialState
        // in the subflow type.
        // subflow.SetInitialState(arg1, arg2);
    }
    
    // Use this method to update the parent state with the result of the sub-flow (if needed)
    // before moving forward with the flow
    public async Task PostExecute_a0d81457c1d1837a(_b366a645d63b3d5e subflow)
    {
        // The below code is an example using the output of the subflow
        // this.UserName = subflow.ProvidedUserName
    }
}
