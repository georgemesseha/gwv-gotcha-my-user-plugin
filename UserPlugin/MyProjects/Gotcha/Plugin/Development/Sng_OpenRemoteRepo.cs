using UserPlugin._GenericServices;

namespace UserPlugin.MyProjects.Gotcha.Plugin.Development;

[ManualTrigger("n3g2s3s", "Open remote repo", "Opens your personal Gotcha's plug-in remote repo in github #.git #plg")]
public class Sng_OpenRemoteRepo : SingletonService
{
	protected override async Task ExecuteAsync()
	{
		// await Dialog.Add.WebPageAsync("Remote Repo", "https://github.com/georgemesseha/gwv-gotcha-my-user-plugin.git");
<<<<<<< HEAD
		await Edge.OpenAsync("https://github.com/georgemesseha/gwv-gotcha-my-user-plugin.git", "Remote Repo");
=======
		Resolve<Trn_Edge>().OpenAsync("https://github.com/georgemesseha/gwv-gotcha-my-user-plugin.git");
>>>>>>> 63f549c01880ff908bec2b9b85f35eddacb85880
		await PauseAsync("Press Enter to exit");
	}
}