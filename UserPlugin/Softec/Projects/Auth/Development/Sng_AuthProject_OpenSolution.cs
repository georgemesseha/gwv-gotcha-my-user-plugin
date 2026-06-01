using UserPlugin._GenericServices;
using UserPlugin._GenericServices.Configuration;

namespace UserPlugin.Softec.Projects.Auth.Development;

[ManualTrigger("k5c1e0p", "Open solution", "Open solution #.sln")]
public class Sng_AuthProject_OpenSolution : SingletonService
{
	protected override async Task ExecuteAsync()
	{
		var sngConfig = Resolve<Sng_Config_SoftecAuth>();
		var sngOpenInRider = Resolve<Sng_OpenInRider>();
		_ = Dialog.Add.TextToSpeakAsync("Opening Auth project in Rider");
		_ = sngOpenInRider.OpenSolutionAsync(sngConfig.SlnFilePath);
		await PauseAsync("You are done!");
	}
}