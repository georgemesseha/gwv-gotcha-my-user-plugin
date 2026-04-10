namespace UserPlugin.Workspace.MyTools.Git;

[ManualTrigger("Untrack a folder or files", "Untracks a folder files from git")]
public class Sng_UntrackFiles : SingletonService
{
	public override async Task ExecuteAsync()
	{
		await AddOrActivateWebPageTabAsync("Untrack a folder or files",
		                                   "https://www.notion.so/Git-How-to-untrack-files-4a4d63657f794d50ac34d9a3b87258b2?source=copy_link");
		await PauseAsync();
	}
}