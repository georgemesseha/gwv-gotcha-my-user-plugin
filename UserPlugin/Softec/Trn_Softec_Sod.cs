
using UserPlugin._GenericServices.Configuration;

namespace UserPlugin.Softec;

[ManualTrigger("🌞 SOD", "Start of day actions")]
public class Trn_Softec_Sod : TransientService
{
	private const string tabPortal = "Portal";
	private const string tabTasks = "Tasks";
	
	protected override async Task ExecuteAsync()
	{
		var config = Resolve<Sng_Config_Softec>();
		await Dialog.Add.WebPageAsync(tabPortal, config.PortalUrl);
		
		_ = Dialog.Add.TextToSpeakAsync("Clock in");
		await Dialog.PauseAsync();
		
		await Dialog.Add.WebPageAsync(tabTasks,"https://www.notion.so/Tasks-e180470b73314986ad21b98d61b877be?source=copy_link");
		
		_ = Dialog.Add.TextToSpeakAsync("Recall your tasks");
		await Dialog.PauseAsync();
		
		
		
	}
}