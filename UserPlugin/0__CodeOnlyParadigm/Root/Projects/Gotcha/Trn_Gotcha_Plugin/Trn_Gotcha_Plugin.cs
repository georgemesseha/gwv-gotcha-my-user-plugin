
[ManualTrigger("💼 Gotcha's Plugin ...", "Gotcha's Plugin")]
public class Trn_Gotcha_Plugin : TransientService
{
	public override async Task ExecuteAsync()
	{
		await Context.Dialog.RouteAsync("What do you want to do:", true,
		                                ("👉🏽 Develop Plugin .sln", typeof(Trn_Gotcha_Plugin_Develop)),
		                                ("👉🏽 Manage Git repo", typeof(Trn_Gotcha_Plugin_GitRepo))
		                               );
	}
}