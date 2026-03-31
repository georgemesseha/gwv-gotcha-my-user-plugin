using UserPlugin._GenericServices;
using UserPlugin._GenericServices.Configuration;

namespace UserPlugin.Gotcha.Plugin.Development;

[ManualTrigger("Manage Git repo", "Opens plugin Git repo in vscode #plg")]
public class Sng_Gotcha_Plugin_GitRepo : TransientService
{
	public override async Task ExecuteAsync()
	{
		var pluginDir = Context.Resolve<Sng_Config_Gotcha>().PluginMainDirPath;
		await Context.Resolve<Sng_OpenInVsCode>().OpenDirectory(pluginDir);
		_ = Context.Dialog.SpeakAsync("Opening Gotcha's plugin Git repo in VSCode");
	}
}