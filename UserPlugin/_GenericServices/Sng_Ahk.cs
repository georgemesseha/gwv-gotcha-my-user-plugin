using System.Diagnostics;

namespace UserPlugin._GenericServices;

public class Sng_AutoHotKey : SingletonService
{
	public string? AhkScriptsFolderPath
	{
		get
		{
			var oneDrivePath = Resolve<Sng_SpecialFoldersRecognizer>().OneDrivePath;
			if (string.IsNullOrEmpty(oneDrivePath)) return null;
			
			return Path.Combine(oneDrivePath, "_Explicit_", "Automation", "AutoHotkey");
		}
	}
	
	public async Task RunAhkScriptAsync(string ahkFilePath)
	{
		var proc = new Process
		{
			StartInfo = new ProcessStartInfo
			{
				FileName = ahkFilePath,
				UseShellExecute = true  // Use shell execute to open with default app
			}
		};

		await Task.Run(() =>
		               {
		proc.Start();
		// proc.WaitForExit();

		               });
		
		// await Run.Command.NonInteractiveAsync(ahkFilePath, "C:/");
	}
}