using UserPlugin._GenericServices;

namespace UserPlugin.Workspace.MyTools.Git;

[ManualTrigger("s8t8n7n", "Change remote origin", "Changes the remote origin of the current repo #set")]
public class Sng_ChangeRemoteOrigin : SingletonService
{
	protected override async Task ExecuteAsync()
	{
		var git = Resolve<Sng_Git>();
		await git.PrintCommand_SetRemoteOriginAsync();
		await Dialog.PauseAsync();
	}
}