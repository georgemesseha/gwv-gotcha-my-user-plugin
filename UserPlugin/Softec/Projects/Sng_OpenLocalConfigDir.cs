using UserPlugin._GenericServices;
using UserPlugin._GenericServices.Configuration;

namespace UserPlugin.Softec.Projects;

[ManualTrigger("📂 Open local config dir", "Opens local config dir in VSCode")]
public class Sng_OpenLocalConfigDir : SingletonService
{
	public override Task ExecuteAsync()
	{
		var config = Resolve<Sng_AllProjectsConfig>();
		var vscode = Resolve<Sng_OpenInVsCode>();
		_ = vscode.OpenDirectoryAsync(config.LocalConfigDir);
		_ = SpeakAsync("Opening local config directory in VSCode");
		return Task.CompletedTask;
	}
}