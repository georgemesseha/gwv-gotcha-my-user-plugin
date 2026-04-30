using UserPlugin._GenericServices;

namespace UserPlugin.My_Projects.Gotcha.LegacyTypeScriptGlobalTool;

[ManualTrigger("Legacy TypeScript Tool", "Legacy TypeScript Gotcha Global Tool")]
public class LegacyTypeScriptTool : SingletonService
{
	public override async Task ExecuteAsync()
	{
		var vscode = Resolve<Sng_OpenInVsCode>();
		await vscode.OpenDirectoryAsync("E:\\_MyProjects\\_MyNodeProjects\\wv-gotcha");
		await Dialog.Add.TextToSpeakAsync("Opening in VSCode");
	}
}