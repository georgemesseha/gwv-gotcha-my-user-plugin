
namespace UserPlugin.My_Projects.AHK;

using UserPlugin._GenericServices;


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
			await Dialog.Add.InfoAsync(triggerFile.FullName);
		}
		// ahk.RunAhkScript("D:\\OneDrive\\_Explicit_\\Automation\\AutoHotkey\\Triggers\\test.ahk");
		_ = Dialog.Add.TextToSpeakAsync("Done executing you ahk scripts");
	}
}