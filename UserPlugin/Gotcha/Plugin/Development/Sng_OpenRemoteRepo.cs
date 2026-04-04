namespace UserPlugin.Gotcha.Plugin.Development;

[ManualTrigger("Open remote repo", "Opens your personal Gotcha's plug-in remote repo in github #.git #plg")]
public class Sng_OpenRemoteRepo : SingletonService
{
	public override async Task ExecuteAsync()
	{
		AddOrActivateWebPageTab("Remote Repo", "https://github.com/georgemesseha/gwv-gotcha-my-user-plugin.git");
		await PauseAsync("Press Enter to exit");
	}
}