
[ManualTrigger("🌞 SOD", "Start of day actions")]
public class Trn_Softec_Sod : TransientService
{
	private const string tabPortal = "Portal";
	private const string tabTasks = "Tasks";
	
	public override async Task ExecuteAsync()
	{
		var config = Context.Resolve<Sng_Config_Softec>();
		Context.Dialog.AddOrActivateSideWebPage(tabPortal, config.PortalUrl);
		
		_ = Context.Dialog.SpeakAsync("Clock in");
		await Context.Dialog.ShowModalMessageBoxAsync();
		
		Context.Dialog.AddOrActivateSideWebPage(tabTasks,"https://www.notion.so/Tasks-e180470b73314986ad21b98d61b877be?source=copy_link");
		
		_ = Context.Dialog.SpeakAsync("Recall your tasks");
		await Context.Dialog.ShowModalMessageBoxAsync();
		
		
		
	}
}