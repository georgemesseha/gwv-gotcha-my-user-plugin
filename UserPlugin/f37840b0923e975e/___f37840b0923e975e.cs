
partial class _f37840b0923e975e
{
    IPluginServices _srv;
     //IExecution _exec;

	public string ProcessName { get; private set;}

	public string Args { get; private set;}

	public string WorkingDir { get; private set;} = "";

	public bool WaitForExit { get; private set;} = false;

	public bool ShowWindow { get; private set;} = true;

	public void Input(string processName, 
					  string args, 
					  bool waitForExit = false, 
					  string workingDir = "", 
					  bool showWindow = true)
	{
		ProcessName = processName;
		Args = args;
		WorkingDir = workingDir;
		WaitForExit = waitForExit;
		ShowWindow = showWindow;
	}
}
