using UserPlugin._GenericServices;

namespace UserPlugin.My_Projects.Gotcha.LegacyTypeScriptGlobalTool;

[ManualTrigger("Legacy TypeScript Tool", "Legacy TypeScript Gotcha Global Tool")]
public class LegacyTypeScriptTool : SingletonService
{
	protected override async Task ExecuteAsync()
	{
		_ = Dialog.Add.TextToSpeakAsync("Opening in VSCode");
		var vscode = Resolve<Sng_OpenInVsCode>();
		_ = vscode.OpenDirectoryAsync("E:\\_MyProjects\\_MyNodeProjects\\wv-gotcha");
		await Dialog.PauseAsync();
	}
}