
partial class _aabd786b0afd1857
{
    // Use this method to initialize the state of the child subflow to provide
    // the initial data to work on.
    public async Task PreExecute_f8138324ef8cea2d(_c4601fbac7a0289f subflow)
    {
        var settingsFilePath = Path.Combine(_nodeRedDirPath, "settings.js");  
        subflow.Input(_nodeRedDirPath, settingsFilePath);   
    }
    
    // Use this method to update the parent state with the result of the sub-flow (if needed)
    // before moving forward with the flow
    public async Task PostExecute_f8138324ef8cea2d(_c4601fbac7a0289f subflow)
    {
        // The below code is an example using the output of the subflow
        // this.UserName = subflow.ProvidedUserName
    }
}
