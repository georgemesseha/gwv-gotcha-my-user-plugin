using UserPlugin._GenericServices;
using UserPlugin._GenericServices.Configuration;

namespace UserPlugin.Gotcha.Plugin.Development;

[ManualTrigger("Open solution", "Opens your personal Gotcha's plug-in solution in rider #.sln")]
public class OpenSolution : TransientService
{
	public override async Task ExecuteAsync()
	{
		var plugnSlnFilePath = Context.Resolve<Sng_Config_Gotcha>().PluginSlnFilePath;
		await Context.Resolve<Sng_OpenInRider>().OpenSolutionAsync(plugnSlnFilePath);
		_ = Context.Dialog.SpeakAsync("Opening Gotcha's plugin solution in Rider");
	}
}