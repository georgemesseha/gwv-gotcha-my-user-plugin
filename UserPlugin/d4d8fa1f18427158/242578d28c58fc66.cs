
partial class _d4d8fa1f18427158
{
    // Use this method to initialize the state of the child subflow to provide
    // the initial data to work on.
    public async Task PreExecute_242578d28c58fc66(_0b110f35afb0eb57 subflow)
    {
        subflow.Input(@"D:\Projects\saaedi-identity-poc");
    }
    
    // Use this method to update the parent state with the result of the sub-flow (if needed)
    // before moving forward with the flow
    public async Task PostExecute_242578d28c58fc66(_0b110f35afb0eb57 subflow)
    {
        // The below code is an example using the output of the subflow
        // this.UserName = subflow.ProvidedUserName
    }
}
