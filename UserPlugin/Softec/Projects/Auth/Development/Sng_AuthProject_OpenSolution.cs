using UserPlugin._GenericServices;
using UserPlugin._GenericServices.Configuration;

namespace UserPlugin.Softec.Projects.Auth.Development;

[ManualTrigger("Open solution", "Open solution #.sln")]
public class Sng_AuthProject_OpenSolution : SingletonService
{
	protected override async Task ExecuteAsync()
	{
		var sngConfig = Resolve<Sng_Config_SoftecAuth>();
		var sngOpenInRider = Resolve<Sng_OpenInRider>();
		await sngOpenInRider.OpenSolutionAsync(sngConfig.SlnFilePath);
		_ = Dialog.Add.TextToSpeakAsync("Opening Auth project in Rider");
	}
}