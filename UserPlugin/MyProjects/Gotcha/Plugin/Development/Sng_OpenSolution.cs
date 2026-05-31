using UserPlugin._GenericServices;
using UserPlugin._GenericServices.Configuration;

namespace UserPlugin.MyProjects.Gotcha.Plugin.Development;

[ManualTrigger("d6g8d7h", "Open solution", "Opens your personal Gotcha's plug-in solution in rider #.sln #plg")]
public class Sng_OpenSolution : SingletonService
{
	protected override async Task ExecuteAsync()
	{
		var plugnSlnFilePath = Resolve<Sng_Config_Gotcha>().PluginSlnFilePath;
		_ = Resolve<Sng_OpenInRider>().OpenSolutionAsync(plugnSlnFilePath);
		_ = Dialog.Add.TextToSpeakAsync("Opening Gotcha's plug-in in Rider");
	}
}