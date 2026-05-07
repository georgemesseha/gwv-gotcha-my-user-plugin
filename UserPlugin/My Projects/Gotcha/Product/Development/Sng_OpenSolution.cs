using UserPlugin._GenericServices;
using UserPlugin._GenericServices.Configuration;

namespace UserPlugin.My_Projects.Gotcha.Product.Development;

[ManualTrigger("s3f0n4p", "Open solution", "Opens Gotcha solution in rider #.sln")]
public class Sng_OpenSolution : TransientService
{
	protected override async Task ExecuteAsync()
	{
		var gotchaSlnFilePath = Resolve<Sng_Config_Gotcha>().GotchaSlnFilePath;
		_ = Resolve<Sng_OpenInRider>().OpenSolutionAsync(gotchaSlnFilePath);
		await Dialog.PauseAsync();
	}
} 