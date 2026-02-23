
partial class _1bde289216f0b707
{
    // Use this method to initialize the state of the child subflow to provide
    // the initial data to work on.
    public async Task PreExecute_86288ca915838649(_b366a645d63b3d5e subflow)
    {
        subflow.Input("https://www.notion.so/Safe-City-Portal-2fb6ea6ef60880a6b7e8e6a16e4b8a0f?source=copy_link");
    }
    
    // Use this method to update the parent state with the result of the sub-flow (if needed)
    // before moving forward with the flow
    public async Task PostExecute_86288ca915838649(_b366a645d63b3d5e subflow)
    {
        // The below code is an example using the output of the subflow
        // this.UserName = subflow.ProvidedUserName
    }
}
