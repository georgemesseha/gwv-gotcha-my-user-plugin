using UserPlugin._GenericServices;

namespace UserPlugin.My_Projects.AHK;

[ManualTrigger("Open AHK Folder in VSCode", "Open AutoHotkey Folder in VSCode. Automation")]
public class Sng_OpenAhkFolderInVsCode : SingletonService
{
	public override async Task ExecuteAsync()
	{
		_ = this.Dialog.Add.TextToSpeakAsync("Opening your AHK scripts in vscode");
		var openInVsCode = Resolve<Sng_OpenInVsCode>();
		var ahk = Resolve<Sng_AutoHotKey>();
		
		var ahkFolderPath = ahk.AhkScriptsFolderPath;
		if(ahkFolderPath == null) 
		{
			await Dialog.Add.ErrorNotationAsync("Your AHK scripts folder doesn't exist");
			return;
		}
		
		await openInVsCode.OpenDirectoryAsync(ahkFolderPath);
		

	}
}