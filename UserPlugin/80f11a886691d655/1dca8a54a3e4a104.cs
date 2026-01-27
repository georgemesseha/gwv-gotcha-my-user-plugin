
partial class _80f11a886691d655
{
    // Use this method to initialize the state of the child subflow to provide
    // the initial data to work on.
    public async Task PreExecute_1dca8a54a3e4a104(_b366a645d63b3d5e subflow)
    {
        subflow.Input("https://portal.azure.com/#@SoftecMEA.onmicrosoft.com/resource/subscriptions/1f01a312-a6f5-4161-993d-4ef40f8ca052/resourceGroups/RG_Saaed_DevOpsTest_Sahel_UAENorth/providers/microsoft.insights/components/aca-dev-env/logs");
    }
    
    // Use this method to update the parent state with the result of the sub-flow (if needed)
    // before moving forward with the flow
    public async Task PostExecute_1dca8a54a3e4a104(_b366a645d63b3d5e subflow)
    {
        // The below code is an example using the output of the subflow
        // this.UserName = subflow.ProvidedUserName
    }
}
