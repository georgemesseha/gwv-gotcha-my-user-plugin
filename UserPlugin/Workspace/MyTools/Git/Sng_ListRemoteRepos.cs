using UserPlugin._GenericServices;

namespace UserPlugin.Workspace.MyTools.Git;

[ManualTrigger("List remote repos", "Lists all remote repos")]
public class Sng_ListRemoteRepos : SingletonService
{
	protected override async Task ExecuteAsync()
	{
		var git = Resolve<Sng_Git>();
		await git.PrintCommand_GetRemoteReposAsync();
		await Dialog.PauseAsync();
	}
}