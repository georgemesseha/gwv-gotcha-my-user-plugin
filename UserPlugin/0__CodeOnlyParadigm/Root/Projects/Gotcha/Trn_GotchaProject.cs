using Gwv.Gotcha.Services.Plugin;

[ManualTrigger("💼 Gotcha", "Gotcha Project")]
public class Trn_GotchaProject : TransientService
{
	public override async Task ExecuteAsync()
	{
		
		await Context.Dialog.InfoAsync("Gotcha Project");
	}
}