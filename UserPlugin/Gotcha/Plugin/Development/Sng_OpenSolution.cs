using UserPlugin._GenericServices;
using UserPlugin._GenericServices.Configuration;

namespace UserPlugin.Gotcha.Plugin.Development;

[ManualTrigger("Open solution", "Opens your personal Gotcha's plug-in solution in rider #.sln #plg")]
public class Sng_OpenSolution : SingletonService
{
	public override async Task ExecuteAsync()
	{
		var plugnSlnFilePath = Resolve<Sng_Config_Gotcha>().PluginSlnFilePath;
		await Resolve<Sng_OpenInRider>().OpenSolutionAsync(plugnSlnFilePath);
		_ = SpeakAsync("Opening Gotcha's plug-in solution in Rider");
	}
}