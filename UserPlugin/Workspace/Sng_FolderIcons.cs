using System.Diagnostics;
using UserPlugin._GenericServices;

namespace UserPlugin.Workspace;

[ManualTrigger("Folder Icons", "Folder Icons, FI")]
public class Sng_FolderIcons : SingletonService
{
	public override async Task ExecuteAsync()
	{
		_ = this.Dialog.Add.TextToSpeakAsync("Opening Folder Icons");

		var oneDrivePath = Resolve<Sng_SpecialFoldersRecognizer>().OneDrivePath;
		var folderIconsPath = Path.Join(oneDrivePath, "_Explicit_", "FI");
		var startInfo = new ProcessStartInfo
		{
			FileName = "cmd.exe",
			Arguments = $"/c cd {folderIconsPath} && start explorer .",
			UseShellExecute = false,
			CreateNoWindow = true
		};
		Process.Start(startInfo);
		
	}
}