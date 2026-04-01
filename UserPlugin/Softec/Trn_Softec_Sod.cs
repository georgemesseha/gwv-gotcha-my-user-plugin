
using UserPlugin._GenericServices.Configuration;

namespace UserPlugin.Softec;

[ManualTrigger("🌞 SOD", "Start of day actions")]
public class Trn_Softec_Sod : TransientService
{
	private const string tabPortal = "Portal";
	private const string tabTasks = "Tasks";
	
	public override async Task ExecuteAsync()
	{
		var config = Resolve<Sng_Config_Softec>();
		AddSideWebPage(tabPortal, config.PortalUrl);
		
		_ = SpeakAsync("Clock in");
		await PauseAsync();
		
		AddSideWebPage(tabTasks,"https://www.notion.so/Tasks-e180470b73314986ad21b98d61b877be?source=copy_link");
		
		_ = SpeakAsync("Recall your tasks");
		await PauseAsync();
		
		
		
	}
}