namespace UserPlugin.Workspace.MyTools.Git;

[ManualTrigger("Edit global git config", "Edits the global git config")]
public class Sng_Git_EditGlobalConfiguration : SingletonService
{
	public override async Task ExecuteAsync()
	{
		await RunCommandInTerminalAsync("git config --global core.editor \"code --wait & git config --global -e",
		                                "C:\\", true);
	}
}