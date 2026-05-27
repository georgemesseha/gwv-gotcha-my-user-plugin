namespace UserPlugin.Workspace.MyTools.NodeJS;

[ManualTrigger("ug1i0l2l", "List package direct dependencies", "List Direct Dependencies of the current package")]
public class Sng_ListDirectDependencies : SingletonService
{
	protected override async Task ExecuteAsync()
	{
		External.RunPowerShellInteractive("npm list --depth=0", "C:\\");
		await PauseAsync("Done with the terminal?");
	}
}