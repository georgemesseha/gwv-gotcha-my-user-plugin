using UserPlugin._GenericServices;
using UserPlugin._GenericServices.Configuration;

namespace UserPlugin.Gotcha.Trn_Gotcha_Solution.Items;

public class Trn_Gotcha_Product_Develop : TransientService
{
	public override async Task ExecuteAsync()
	{
		var gotchaSlnFilePath = Context.Resolve<Sng_Config_Gotcha>().GotchaSlnFilePath;
		await Context.Resolve<Sng_OpenInRider>().OpenSolutionAsync(gotchaSlnFilePath);
		// Context.Dismiss();
	}
}