namespace UserPlugin.Workspace.MyTools.Git;

[ManualTrigger("Edit global git config", "Edits the global git config")]
public class Sng_Git_EditGlobalConfiguration : SingletonService
{
	protected override async Task ExecuteAsync()
	{
		await Integration.RunProcessAsync("git config --global --replace-all core.editor \"code --wait\"; git config --global -e",
		                                "C:\\");
		await Dialog.PauseAsync();
	}
}