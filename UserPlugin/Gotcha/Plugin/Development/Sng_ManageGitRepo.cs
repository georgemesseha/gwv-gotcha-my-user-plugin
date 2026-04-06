using UserPlugin._GenericServices;
using UserPlugin._GenericServices.Configuration;

namespace UserPlugin.Gotcha.Plugin.Development;

[ManualTrigger("Manage Git repo", "Opens plugin Git repo in vscode #plg")]
public class Sng_ManageGitRepo : TransientService
{
	public override async Task ExecuteAsync()
	{
		var pluginDir = Resolve<Sng_Config_Gotcha>().PluginMainDirPath;
		await Resolve<Sng_OpenInVsCode>().OpenDirectoryAsync(pluginDir);
		_ = SpeakAsync("Opening Gotcha's plugin Git repo in VSCode");
	}
}