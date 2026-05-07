namespace UserPlugin.Workspace.MyTools.NodeJS;

[ManualTrigger("ug1i0l2l", "List package direct dependencies", "List Direct Dependencies of the current package")]
public class Sng_ListDirectDependencies : SingletonService
{
	protected override async Task ExecuteAsync()
	{
		await Run.Command.InteractiveAsync("npm list --depth=0", "C:\\");
	}
}