
partial class _aabd786b0afd1857
{
    // Use this method to initialize the state of the child subflow to provide
    // the initial data to work on.
    public async Task PreExecute_40163127dc10720e(_0b110f35afb0eb57 subflow)
    {
        subflow.Input(Path.Combine(this._exePath));
    }
    
    // Use this method to update the parent state with the result of the sub-flow (if needed)
    // before moving forward with the flow
    public async Task PostExecute_40163127dc10720e(_0b110f35afb0eb57 subflow)
    {
        // The below code is an example using the output of the subflow
        // this.UserName = subflow.ProvidedUserName
    }
}
