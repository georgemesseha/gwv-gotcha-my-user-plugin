using UserPlugin._GenericServices;
using UserPlugin._GenericServices.Configuration;

namespace UserPlugin.My_Projects.Gotcha.Product.Development;

[ManualTrigger("Open solution", "Opens Gotcha solution in rider #.sln")]
public class Sng_OpenSolution : TransientService
{
	public override async Task ExecuteAsync()
	{
		var gotchaSlnFilePath = Resolve<Sng_Config_Gotcha>().GotchaSlnFilePath;
		_ = Resolve<Sng_OpenInRider>().OpenSolutionAsync(gotchaSlnFilePath);
		await PauseAsync();
	}
} 