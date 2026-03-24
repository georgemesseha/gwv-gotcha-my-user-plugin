
[ManualTrigger("🌇 EOD", "End of day actions")]
public class Trn_Softec_Eod : TransientService
{
	private const string tabDailyReportNotionPage = "Daily Report";
	private const string tabPortal = "Portal";
	private const string tabChatGPT = "ChatGPT";
	
	public override async Task ExecuteAsync()
	{
		var config = Context.Resolve<Sng_Config_Softec>();
		
		Context.Dialog.AddOrActivateSideWebPage(tabChatGPT, "https://chat.openai.com/");
		Context.Dialog.AddOrActivateSideWebPage(tabPortal, config.PortalUrl);
		Context.Dialog.AddOrActivateSideWebPage(tabDailyReportNotionPage, config.DailyReportUrl);
		
		

		_ = Context.Dialog.SpeakAsync("Prepare your report then resume the conversation.");
		await Context.Dialog.ShowModalMessageBox();
		_ = Context.Dialog.SpeakAsync("Copy your report.");
		await Context.Dialog.ShowModalMessageBox();
		_ = Context.Dialog.SpeakAsync("Let ChatGPT polish your report!");
		Context.Dialog.AddOrActivateSideWebPage("ChatGPT", "https://chat.openai.com/");
		await Context.Dialog.ShowModalMessageBox();
		_ = Context.Dialog.SpeakAsync("Update the polished report in your Notion page.");
		Context.Dialog.AddOrActivateSideWebPage("Daily Report", config.DailyReportUrl);
		await Context.Dialog.ShowModalMessageBox();
		_ = Context.Dialog.SpeakAsync("Review your report.");
		await Context.Dialog.ShowModalMessageBox();
		
		Context.Dialog.AddOrActivateSideWebPage("Portal", config.PortalUrl);
		_ = Context.Dialog.SpeakAsync("Clock out and paste your report");
		await Context.Dialog.ShowModalMessageBox();
		_ = Context.Dialog.SpeakAsync("You are done. Press Enter to exit!");
		await Context.Dialog.ShowModalMessageBox("You are done. Press Enter to exit!");
		Context.Dialog.Dismiss();
	}
}