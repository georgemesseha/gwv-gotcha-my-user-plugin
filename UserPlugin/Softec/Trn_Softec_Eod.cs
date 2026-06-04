
using UserPlugin._GenericServices;

namespace UserPlugin.Softec;

[ManualTrigger("n6x6s7s", "🌇 EOD", "End of day actions")]
public class Trn_Softec_Eod : TransientService
{
	protected override async Task ExecuteAsync()
	{
		var commonTabs = Resolve<Sng_CommonTabs>();
		
		await Edge.OpenAsync(commonTabs.Url_ChatGPT, commonTabs.Tab_ChatGPT, "gpt"); 
			
		await Notion.OpenAsync("3016ea6ef608801a8a16cb167299e695", "Daily Report Draft");
		// await Dialog.Add.WebPageAsync(commonTabs.Tab_SaaedDailyReport, commonTabs.Url_SaaedDailyReport);
		

		_ = Dialog.Add.TextToSpeakAsync("Prepare your report then resume the conversation.");
		await PauseAsync();
		_ = Dialog.Add.TextToSpeakAsync("Copy your report.");
		await PauseAsync();
		_ = Dialog.Add.TextToSpeakAsync("Let ChatGPT polish your report!");
		
		
		await Resolve<Trn_Edge>().OpenAsync(commonTabs.Url_ChatGPT, "Chat GPT > Refine report", "chat", "gpt");
		// await Dialog.Add.WebPageAsync(commonTabs.Tab_ChatGPT, commonTabs.Url_ChatGPT);
		await PauseAsync();
		_ = Dialog.Add.TextToSpeakAsync("Update the polished report in your Notion page.");
		
		// await Dialog.Add.WebPageAsync(commonTabs.Tab_SaaedDailyReport, commonTabs.Url_SaaedDailyReport);
		await Notion.OpenAsync("3016ea6ef608801a8a16cb167299e695", "Daily Report Notes");
		
		await PauseAsync();
		_ = Dialog.Add.TextToSpeakAsync("Review your report.");
		await PauseAsync();

		await Resolve<Sng_SafeCity>().OpenPortalPwaAsync();
		// await DefaultBrowser.OpenAsync("https://safecityportal.com/stream/");

		await Resolve<Sng_SafeCity>().OpenPortalPwaAsync();
		_ = Dialog.Add.TextToSpeakAsync("Clock out and paste your report");
		await PauseAsync();
		
		_ = Dialog.Add.TextToSpeakAsync("You are done.");
		await PauseAsync("Exit?");
	}
}