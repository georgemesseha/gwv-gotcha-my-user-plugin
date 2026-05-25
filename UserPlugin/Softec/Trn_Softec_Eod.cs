
using UserPlugin._GenericServices;

namespace UserPlugin.Softec;

[ManualTrigger("n6x6s7s", "🌇 EOD", "End of day actions")]
public class Trn_Softec_Eod : TransientService
{
	protected override async Task ExecuteAsync()
	{
		var commonTabs = Resolve<Sng_CommonTabs>();
		
		await Dialog.Add.WebPageAsync(commonTabs.Tab_ChatGPT, commonTabs.Url_ChatGPT);
		await Dialog.Add.WebPageAsync(commonTabs.Tab_SafeCityPortal, commonTabs.Url_SafeCityPortal);
		await Dialog.Add.WebPageAsync(commonTabs.Tab_SaaedDailyReport, commonTabs.Url_SaaedDailyReport);
		

		_ = Dialog.Add.TextToSpeakAsync("Prepare your report then resume the conversation.");
		await PauseAsync();
		_ = Dialog.Add.TextToSpeakAsync("Copy your report.");
		await PauseAsync();
		_ = Dialog.Add.TextToSpeakAsync("Let ChatGPT polish your report!");
		await Dialog.Add.WebPageAsync(commonTabs.Tab_ChatGPT, commonTabs.Url_ChatGPT);
		await PauseAsync();
		_ = Dialog.Add.TextToSpeakAsync("Update the polished report in your Notion page.");
		await Dialog.Add.WebPageAsync(commonTabs.Tab_SaaedDailyReport, commonTabs.Url_SaaedDailyReport);
		await PauseAsync();
		_ = Dialog.Add.TextToSpeakAsync("Review your report.");
		await PauseAsync();

		await Resolve<Sng_Softec_OpenSafeCityPortal>().OpenAsync(); 
		_ = Dialog.Add.TextToSpeakAsync("Clock out and paste your report");
		await PauseAsync();
		
		_ = Dialog.Add.TextToSpeakAsync("You are done.");
		await PauseAsync("Exit?");
	}
}