
using UserPlugin._GenericServices;

namespace UserPlugin.Softec;

[ManualTrigger("n6x6s7s", "🌇 EOD", "End of day actions")]
public class Trn_Softec_Eod : TransientService
{
	private async Task OpenDailyReportDraftAsync()
	{
		await Notion.OpenAsync("3016ea6ef608801a8a16cb167299e695", "Daily Report Draft");
	}

	private async Task OpenPortalAsync()
	{
		await Resolve<Sng_SafeCity>().OpenPortalPwaAsync();
	}
	
	protected override async Task ExecuteAsync()
	{
<<<<<<< HEAD
		await OpenDailyReportDraftAsync();
=======
		var commonTabs = Resolve<Sng_CommonTabs>();
		
		Resolve<Trn_Edge>().OpenAsync(commonTabs.Url_ChatGPT, commonTabs.Tab_ChatGPT);
		// await Dialog.Add.WebPageAsync(commonTabs.Tab_ChatGPT, commonTabs.Url_ChatGPT);
		// await Dialog.Add.WebPageAsync(commonTabs.Tab_SafeCityPortal, commonTabs.Url_SafeCityPortal);

		
		await Resolve<Sng_Notion>().GrabNotion("3016ea6ef608801a8a16cb167299e695", "Daily Report Notes");
		// await Dialog.Add.WebPageAsync(commonTabs.Tab_SaaedDailyReport, commonTabs.Url_SaaedDailyReport);
		
>>>>>>> 63f549c01880ff908bec2b9b85f35eddacb85880

		_ = Dialog.Add.TextToSpeakAsync("Prepare your report then resume the conversation.");
		await PauseAsync();
		_ = Dialog.Add.TextToSpeakAsync("Copy your report."); 
		await PauseAsync();
		_ = Dialog.Add.TextToSpeakAsync("Let ChatGPT polish your report!");
		
		
<<<<<<< HEAD
		await Edge.OpenAsync(Resolve<Sng_CommonTabs>().Url_ChatGPT, "Chat GPT > Refine report", "chat", "gpt");
		
		await PauseAsync();
		_ = Dialog.Add.TextToSpeakAsync("Update the polished report in your Notion page.");

		await OpenDailyReportDraftAsync();
=======
		Resolve<Trn_Edge>().OpenAsync(commonTabs.Url_ChatGPT);
		// await Dialog.Add.WebPageAsync(commonTabs.Tab_ChatGPT, commonTabs.Url_ChatGPT);
		await PauseAsync();
		_ = Dialog.Add.TextToSpeakAsync("Update the polished report in your Notion page.");
		
		// await Dialog.Add.WebPageAsync(commonTabs.Tab_SaaedDailyReport, commonTabs.Url_SaaedDailyReport);
		await Resolve<Sng_Notion>().GrabNotion("3016ea6ef608801a8a16cb167299e695", "Daily Report Notes");
>>>>>>> 63f549c01880ff908bec2b9b85f35eddacb85880
		
		await PauseAsync();
		_ = Dialog.Add.TextToSpeakAsync("Review your report.");
		await PauseAsync();

<<<<<<< HEAD
		await OpenPortalAsync();
=======
		await Resolve<Sng_SafeCity>().OpenPortalPwaAsync();
		// await DefaultBrowser.OpenAsync("https://safecityportal.com/stream/");

		await Resolve<Sng_SafeCity>().OpenPortalPwaAsync();
>>>>>>> 63f549c01880ff908bec2b9b85f35eddacb85880
		_ = Dialog.Add.TextToSpeakAsync("Clock out and paste your report");
		await PauseAsync();
		
		_ = Dialog.Add.TextToSpeakAsync("You are done.");
		await PauseAsync("Exit?");
	}
}