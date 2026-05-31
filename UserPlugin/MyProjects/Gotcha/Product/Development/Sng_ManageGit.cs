using UserPlugin._GenericServices;
using UserPlugin._GenericServices.Configuration;

namespace UserPlugin.MyProjects.Gotcha.Product.Development;

[ManualTrigger("g1r4l3j", "Manage Git repo", "Opens Git repo in vscode")]
public class Sng_ManageGit : SingletonService
{
	protected override Task ExecuteAsync()
	{
		var vscode = Resolve<Sng_OpenInVsCode>();
		var config = Resolve<Sng_Config_Gotcha>();
		_ = vscode.OpenDirectoryAsync(config.GotchaMainDirPath);
		_ = Dialog.Add.TextToSpeakAsync("Opening Gotcha repo in VSCode");
		return Task.CompletedTask;
	}
}