namespace UserPlugin.Workspace.MyTools.NodeJS;

[ManualTrigger("List globally installed npm packages", "Lists all globally installed packages npm nodejs")]
public class Sng_ListGloballyInstalledPackages : SingletonService
{
	public override async Task ExecuteAsync()
	{
		await RunCommandInTerminalAsync("npm list -g", "C:\\");
	}
}