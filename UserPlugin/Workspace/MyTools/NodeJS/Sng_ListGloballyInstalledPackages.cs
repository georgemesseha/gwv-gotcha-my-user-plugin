namespace UserPlugin.Workspace.MyTools.NodeJS;

[ManualTrigger("c4i1u3a", "List globally installed npm packages", "Lists all globally installed packages npm nodejs")]
public class Sng_ListGloballyInstalledPackages : SingletonService
{
	protected override async Task ExecuteAsync()
	{

		await Run.Command.InteractiveAsync("npm list -g", "C:\\");
		// await Run.Command.InteractiveAsync("npm list -g", "C:\\");
	}
}