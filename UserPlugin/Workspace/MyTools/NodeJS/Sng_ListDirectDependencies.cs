namespace UserPlugin.Workspace.MyTools.NodeJS;

[ManualTrigger("List package direct dependencies", "List Direct Dependencies of the current package")]
public class Sng_ListDirectDependencies : SingletonService
{
	public override async Task ExecuteAsync()
	{
		await RunCommandInTerminalAsync("npm list --depth=0", "C:\\");
	}
}