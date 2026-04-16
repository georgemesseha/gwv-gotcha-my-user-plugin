using System.Diagnostics;
using System.Reflection;

namespace UserPlugin.Fun;

[ManualTrigger("VHD", "VHD")]
public class Sng_Vhd : SingletonService
{
	public override async Task ExecuteAsync()
	{
		await RunVhdAsync();
		await RunDesktopsAsync();
	}
	
	private async Task RunDesktopsAsync()
	{
		var desktopsPath = "J:\\Toolbox\\Software\\Usabilitty\\Multiple Desktop\\Desktops64.exe";
		
		if (File.Exists(desktopsPath) == false)
		{
			throw new Exception("Desktops64.exe not found");
		}
		
		var process = new Process
		{
			StartInfo = new ProcessStartInfo
			{
				FileName = desktopsPath,
				Arguments = "--verbose",
				UseShellExecute = false,
				RedirectStandardOutput = true,
				CreateNoWindow = true
			}
		};

		process.Start();

		string output = await process.StandardOutput.ReadToEndAsync();
		await PauseAsync(output);
	}
	
	private async Task RunVhdAsync()
	{
		var baseDir = new FileInfo(Assembly.GetEntryAssembly()!.Location).Directory;
		var batFilePath = Path.Join(baseDir!.FullName, "_Scripts", "1vhd.bat");
		
		if (File.Exists(batFilePath) == false)
		{
			throw new Exception("Bat file not found");
		}
		
		var process = new Process
		{
			StartInfo = new ProcessStartInfo
			{
				FileName = "cmd.exe",
				Arguments = $"/c {batFilePath}",
				UseShellExecute = false,
				RedirectStandardOutput = true,
				CreateNoWindow = true
			}
		};

		process.Start();

		string output = await process.StandardOutput.ReadToEndAsync();
		await PauseAsync(output);
	}
}