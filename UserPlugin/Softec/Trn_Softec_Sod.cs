
using UserPlugin._GenericServices;
using UserPlugin._GenericServices.Configuration;

namespace UserPlugin.Softec;

[ManualTrigger("e2f4i1h", "🌞 SOD", "Start of day actions")]
public class Trn_Softec_Sod : TransientService
{
	private const string tabPortal = "Portal";
	private const string tabTasks = "Tasks";
	
	protected override async Task ExecuteAsync()
	{
		var config = Resolve<Sng_Config_Softec>();
		// await Dialog.Add.WebPageAsync(tabPortal, config.PortalUrl);
		// await DefaultBrowser.OpenAsync("https://safecityportal.com/stream/");
		await Resolve<Sng_SafeCity>().OpenPortalPwaAsync();
		
		
		_ = Dialog.Add.TextToSpeakAsync("Clock in");
		await PauseAsync();
		
<<<<<<< HEAD
		await Notion.OpenAsync("e180470b73314986ad21b98d61b877be", tabTasks);
=======
		await Resolve<Sng_Notion>().GrabNotion("e180470b73314986ad21b98d61b877be", tabTasks);
>>>>>>> 63f549c01880ff908bec2b9b85f35eddacb85880
		// await Dialog.Add.WebPageAsync(tabTasks,"https://www.notion.so/Tasks-e180470b73314986ad21b98d61b877be?source=copy_link");
		
		_ = Dialog.Add.TextToSpeakAsync("Recall your tasks");
		await PauseAsync();
		
		
		
	}
}