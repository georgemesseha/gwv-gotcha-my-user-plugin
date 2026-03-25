using Gwv.Gotcha.Services.Plugin;

[ManualTrigger("Projects", "Your currently active projects")]
public class Trn_Projects : TransientService
{
	
	public override async Task ExecuteAsync()
	{
		var service = await Context.Dialog.PickServiceAsync("What project?",
		                                                    ("Sahel", typeof(Trn_SahelProject)),
		                                                    ("Gotcha", typeof(Trn_GotchaProject)),
		                                                    ("Auth", typeof(Sng_AuthProject)));
		await service.ExecuteAsync();
	}
}