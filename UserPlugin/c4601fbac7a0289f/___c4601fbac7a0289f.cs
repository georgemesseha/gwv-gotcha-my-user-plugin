
partial class _c4601fbac7a0289f
{
    IPluginServices _srv;
     //IExecution _exec;

	public string DirPath { get; private set;}

	public string? FilePath { get; private set;}

	public void Input(string dirPath, string? filePath = null)
	{
		DirPath = dirPath;
		FilePath = filePath;
	}
}
