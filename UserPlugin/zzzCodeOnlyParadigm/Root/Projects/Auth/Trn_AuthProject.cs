using Gwv.Gotcha.Services.Plugin;

[ManualTrigger("💼 Auth", "Auth Project")]
public class Trn_AuthProject : TransientService
{
	public override async Task ExecuteAsync()
	{
		
		await Context.Dialog.InfoAsync("Auth Project");
	}
}