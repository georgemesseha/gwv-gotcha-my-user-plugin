
partial class _2a4ca6049d860ca7
{
    // Use this method to initialize the state of the child subflow to provide
    // the initial data to work on.
    public async Task PreExecute_57208f5fc3e2978b(_b366a645d63b3d5e subflow)
    {
        subflow.Input("https://portal.azure.com/?feature.tokencaching=true&feature.internalgraphapiversion=true#@SoftecMEA.onmicrosoft.com/resource/subscriptions/1f01a312-a6f5-4161-993d-4ef40f8ca052/resourceGroups/RG_Saaed_DevOpsTest_Sahel_UAENorth/providers/Microsoft.KeyVault/vaults/sahel/secrets");
    }
    
    // Use this method to update the parent state with the result of the sub-flow (if needed)
    // before moving forward with the flow
    public async Task PostExecute_57208f5fc3e2978b(_b366a645d63b3d5e subflow)
    {
        // The below code is an example using the output of the subflow
        // this.UserName = subflow.ProvidedUserName
    }
}
