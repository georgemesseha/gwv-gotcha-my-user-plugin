using UserPlugin._GenericServices;
using UserPlugin._GenericServices.Configuration;

namespace UserPlugin.Softec.Projects.Auth.Development;

[ManualTrigger("Manage Git repo", "Opens Git repo in vscode")]
public class Sng_AuthProject_ManageGit : SingletonService
{
	public override Task ExecuteAsync()
	{
		var vscode = Resolve<Sng_OpenInVsCode>();
		var config = Resolve<Sng_Config_SoftecAuth>();
		_ = vscode.OpenDirectoryAsync(config.MainProjectPath);
		_ = SpeakAsync("Opening in VSCode");
		return Task.CompletedTask;
	}
}