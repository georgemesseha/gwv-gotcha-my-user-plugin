
partial class _340b866f63df92b7
{
    // Use this method to initialize the state of the child subflow to provide
    // the initial data to work on.
    public async Task PreExecute_897b2d0c7140fa6b(_b366a645d63b3d5e subflow)
    {
        _ = _srv.ProcessRunner.OpenUrlInDefaultBrowserAsync(this._frontEndUrl);
    }
    
    // Use this method to update the parent state with the result of the sub-flow (if needed)
    // before moving forward with the flow
    public async Task PostExecute_897b2d0c7140fa6b(_b366a645d63b3d5e subflow)
    {
        
    }
}
