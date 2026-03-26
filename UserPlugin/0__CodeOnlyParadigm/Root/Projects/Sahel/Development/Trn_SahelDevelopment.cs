
using Gwv.Gotcha.Services.Plugin;

public class Trn_SahelDevelopment : TransientService
{
	public override async Task ExecuteAsync()
	{
		await Context.Dialog.RouteAsync("What do you want to do:", true,
		                                ("Open .sln", typeof(Trn_Sahel_Rider_OpenSln)),
		                                ("Manage Git repo", typeof(Trn_Sahel_ManageGitRepo))
		                               );
	}
}