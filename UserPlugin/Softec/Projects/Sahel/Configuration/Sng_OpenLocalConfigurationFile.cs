using UserPlugin._GenericServices;
using UserPlugin._GenericServices.Configuration;

namespace UserPlugin.Softec.Projects.Sahel.Configuration;

[ManualTrigger("n2m6s7s", "Open local config", "Opens local configuration file in Rider")]
public class Sng_OpenLocalConfigurationFile : SingletonService
{
	protected override Task ExecuteAsync()
	{
		var sngConfig = Resolve<Sng_Config_Sahel>();
		var sngOpenInRider = Resolve<Sng_OpenInRider>();
		_ = sngOpenInRider.OpenFileAsync(sngConfig.LocalConfigFile);
		_ = Dialog.Add.TextToSpeakAsync("Opening local configuration in Rider");
		return Task.CompletedTask;
	}
}