using UserPlugin._GenericServices;
using UserPlugin._GenericServices.Configuration;

namespace UserPlugin.Gotcha.Product.Development;

[ManualTrigger("Manage Git repo", "Opens Git repo in vscode")]
public class Sng_ManageGit : SingletonService
{
	public override Task ExecuteAsync()
	{
		var vscode = Context.Resolve<Sng_OpenInVsCode>();
		var config = Context.Resolve<Sng_Config_Gotcha>();
		_ = vscode.OpenDirectory(config.GotchaMainDirPath);
		_ = Context.Dialog.SpeakAsync("Opening Gotcha repo in VSCode");
		return Task.CompletedTask;
	}
}