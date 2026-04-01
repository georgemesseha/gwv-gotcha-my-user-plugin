using UserPlugin._GenericServices;
using UserPlugin._GenericServices.Configuration;

namespace UserPlugin.Gotcha.Product.Development;

[ManualTrigger("Open solution", "Opens Gotcha solution in rider #.sln")]
public class Sng_OpenSolution : TransientService
{
	public override async Task ExecuteAsync()
	{
		var gotchaSlnFilePath = Resolve<Sng_Config_Gotcha>().GotchaSlnFilePath;
		await Resolve<Sng_OpenInRider>().OpenSolutionAsync(gotchaSlnFilePath);
		// Context.Dismiss();
	}
}