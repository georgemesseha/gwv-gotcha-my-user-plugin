using UserPlugin._GenericServices;
using UserPlugin._GenericServices.Configuration;

namespace UserPlugin.Softec.Projects.Auth.Development;

[ManualTrigger("p7x7v5n", "Manage Git repo", "Opens Git repo in vscode")]
public class Sng_AuthProject_ManageGit : SingletonService
{
	protected override Task ExecuteAsync()
	{
		var vscode = Resolve<Sng_OpenInVsCode>();
		var config = Resolve<Sng_Config_SoftecAuth>();
		_ = vscode.OpenDirectoryAsync(config.MainProjectPath);
		_ = Dialog.Add.TextToSpeakAsync("Opening in VSCode");
		return Task.CompletedTask;
	}
}