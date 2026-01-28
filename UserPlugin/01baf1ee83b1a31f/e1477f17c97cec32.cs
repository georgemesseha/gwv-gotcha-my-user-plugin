
partial class _01baf1ee83b1a31f
{
    // Use this method to initialize the state of the child subflow to provide
    // the initial data to work on.
    public async Task PreExecute_e1477f17c97cec32(_b366a645d63b3d5e subflow)
    {
        subflow.Input("https://www.notion.so/Gemini-Chatbot-Project-2f36ea6ef6088058896aedf8ec8e824f?source=copy_link");
    }
    
    // Use this method to update the parent state with the result of the sub-flow (if needed)
    // before moving forward with the flow
    public async Task PostExecute_e1477f17c97cec32(_b366a645d63b3d5e subflow)
    {
        // The below code is an example using the output of the subflow
        // this.UserName = subflow.ProvidedUserName
    }
}
