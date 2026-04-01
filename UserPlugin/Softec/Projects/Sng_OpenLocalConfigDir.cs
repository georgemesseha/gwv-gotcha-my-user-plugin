using UserPlugin._GenericServices;
using UserPlugin._GenericServices.Configuration;

namespace UserPlugin.Softec.Projects;

[ManualTrigger("📂 Open local config dir", "Opens local config dir in explorer")]
public class Sng_OpenLocalConfigDir : SingletonService
{
	public override Task ExecuteAsync()
	{
		var config = Resolve<Sng_AllProjectsConfig>();
		var rider = Resolve<Sng_OpenInRider>();
		_ = rider.OpenDirectoryAsync(config.LocalConfigDir);
		_ = SpeakAsync("Opening local config directory in Rider");
		return Task.CompletedTask;
	}
}