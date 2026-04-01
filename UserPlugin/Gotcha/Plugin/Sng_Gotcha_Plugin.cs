
using UserPlugin.Gotcha.Plugin.Development;

namespace UserPlugin.Gotcha.Plugin;

[ManualTrigger("Overview", "Your personal Gotcha's Plugin overview #plg")]
public class Sng_Gotcha_Plugin : SingletonService
{
	public override async Task ExecuteAsync()
	{
		await Context.Dialog.RouteAsync("What do you want to do:", true,
		                                ("👉🏽 Develop Plugin .sln", typeof(Sng_OpenSolution)),
		                                ("👉🏽 Manage Git repo", typeof(Sng_ManageGitRepo))
		                               );
	}
}