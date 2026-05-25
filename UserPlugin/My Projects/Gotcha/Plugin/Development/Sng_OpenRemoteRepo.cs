namespace UserPlugin.My_Projects.Gotcha.Plugin.Development;

[ManualTrigger("n3g2s3s", "Open remote repo", "Opens your personal Gotcha's plug-in remote repo in github #.git #plg")]
public class Sng_OpenRemoteRepo : SingletonService
{
	protected override async Task ExecuteAsync()
	{
		await Dialog.Add.WebPageAsync("Remote Repo", "https://github.com/georgemesseha/gwv-gotcha-my-user-plugin.git");
		await PauseAsync("Press Enter to exit");
	}
}