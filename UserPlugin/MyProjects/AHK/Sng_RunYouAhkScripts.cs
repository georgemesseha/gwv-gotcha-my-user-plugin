
using UserPlugin._GenericServices;

namespace UserPlugin.MyProjects.AHK;

[ManualTrigger("o5j9q2r", "Run your startup AHK scripts", "Run Your Autohotkey Scripts. start, execute")]
public class Sng_RunYouAhkScripts : SingletonService
{
	protected override async Task ExecuteAsync()
	{
		var ahk = Resolve<Sng_AutoHotKey>();
		var triggersPath = Path.Join(ahk.AhkScriptsFolderPath, "Triggers");
		var allTriggerFiles = new DirectoryInfo(triggersPath).GetFiles("*.ahk");
		foreach (var triggerFile in allTriggerFiles)
		{
			if (IsMarkedForTermination) return;
			
			await ahk.RunAhkScriptAsync(triggerFile.FullName);
			Console.Beep(300, 200);
			// await Dialog.Add.InfoAsync(triggerFile.FullName);
		}
		// ahk.RunAhkScript("D:\\OneDrive\\_Explicit_\\Automation\\AutoHotkey\\Triggers\\test.ahk");
		_ = Dialog.Add.TextToSpeakAsync("Done executing you ahk scripts");
	}
}