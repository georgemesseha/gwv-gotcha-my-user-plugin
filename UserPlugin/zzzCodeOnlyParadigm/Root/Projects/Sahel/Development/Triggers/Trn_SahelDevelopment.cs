
using Gwv.Gotcha.Services.Plugin;

public class Trn_SahelDevelopment : TransientService
{
	public override async Task ExecuteAsync()
	{
		await Context.Dialog.InfoAsync("Sahel Development");
	}
}