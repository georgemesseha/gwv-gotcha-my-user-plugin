
[ManualTrigger("🌇 EOD", "End of day actions")]
public class Trn_Softec_Eod : TransientService
{
	// private const string tabDailyReportNotionPage = "Daily Report";
	// private const string tabPortal = "Portal";
	// private const string tabChatGPT = "ChatGPT";
	
	public override async Task ExecuteAsync()
	{
		var commonTabs = Context.Resolve<Sng_CommonTabs>();
		
		Context.Dialog.AddOrActivateSideWebPage(commonTabs.Tab_ChatGPT, commonTabs.Url_ChatGPT);
		Context.Dialog.AddOrActivateSideWebPage(commonTabs.Tab_SafeCityPortal, commonTabs.Url_SafeCityPortal);
		Context.Dialog.AddOrActivateSideWebPage(commonTabs.Tab_SaaedDailyReport, commonTabs.Url_SaaedDailyReport);
		
		

		_ = Context.Dialog.SpeakAsync("Prepare your report then resume the conversation.");
		await Context.Dialog.ShowModalMessageBoxAsync();
		_ = Context.Dialog.SpeakAsync("Copy your report.");
		await Context.Dialog.ShowModalMessageBoxAsync();
		_ = Context.Dialog.SpeakAsync("Let ChatGPT polish your report!");
		Context.Dialog.AddOrActivateSideWebPage(commonTabs.Tab_ChatGPT, commonTabs.Url_ChatGPT);
		await Context.Dialog.ShowModalMessageBoxAsync();
		_ = Context.Dialog.SpeakAsync("Update the polished report in your Notion page.");
		Context.Dialog.AddOrActivateSideWebPage(commonTabs.Tab_SaaedDailyReport);
		await Context.Dialog.ShowModalMessageBoxAsync();
		_ = Context.Dialog.SpeakAsync("Review your report.");
		await Context.Dialog.ShowModalMessageBoxAsync();

		await Context.Resolve<Sng_Softec_OpenSafeCityPortal>().ExecuteAsync();
		// Context.Dialog.AddOrActivateSideWebPage(commonTabs.Tab_SafeCityPortal, commonTabs.Url_SafeCityPortal);
		_ = Context.Dialog.SpeakAsync("Clock out and paste your report");
		await Context.Dialog.ShowModalMessageBoxAsync();
		_ = Context.Dialog.SpeakAsync("You are done. Press Enter to exit!");
		await Context.Dialog.ShowModalMessageBoxAsync("Exit?");
		Context.Dialog.Dismiss();
	}
}