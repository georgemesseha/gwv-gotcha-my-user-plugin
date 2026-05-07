using UserPlugin._GenericServices;
using UserPlugin._GenericServices.Configuration;

namespace UserPlugin.My_Projects.Gotcha.Plugin.Development;

[ManualTrigger("8i3h5d", "Manage Git repo", "Opens plugin Git repo in vscode #plg")]
public class Sng_ManageGitRepo : TransientService
{
	protected override async Task ExecuteAsync()
	{
		var pluginDir = Resolve<Sng_Config_Gotcha>().PluginMainDirPath;
		await Resolve<Sng_OpenInVsCode>().OpenDirectoryAsync(pluginDir);
		_ = Dialog.Add.TextToSpeakAsync("Opening Gotcha's plugin Git repo in VSCode");
	}
}