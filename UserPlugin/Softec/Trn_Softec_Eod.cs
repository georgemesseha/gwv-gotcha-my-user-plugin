
using UserPlugin._GenericServices;

namespace UserPlugin.Softec;

[ManualTrigger("🌇 EOD", "End of day actions")]
public class Trn_Softec_Eod : TransientService
{
	public override async Task ExecuteAsync()
	{
		var commonTabs = Resolve<Sng_CommonTabs>();
		
		await Dialog.Add.WebPageAsync(commonTabs.Tab_ChatGPT, commonTabs.Url_ChatGPT);
		await Dialog.Add.WebPageAsync(commonTabs.Tab_SafeCityPortal, commonTabs.Url_SafeCityPortal);
		await Dialog.Add.WebPageAsync(commonTabs.Tab_SaaedDailyReport, commonTabs.Url_SaaedDailyReport);
		

		_ = Dialog.Add.TextToSpeakAsync("Prepare your report then resume the conversation.");
		await Dialog.PauseAsync();
		_ = Dialog.Add.TextToSpeakAsync("Copy your report.");
		await Dialog.PauseAsync();
		_ = Dialog.Add.TextToSpeakAsync("Let ChatGPT polish your report!");
		await Dialog.Add.WebPageAsync(commonTabs.Tab_ChatGPT, commonTabs.Url_ChatGPT);
		await Dialog.PauseAsync();
		_ = Dialog.Add.TextToSpeakAsync("Update the polished report in your Notion page.");
		await Dialog.Add.WebPageAsync(commonTabs.Tab_SaaedDailyReport, commonTabs.Url_SaaedDailyReport);
		await Dialog.PauseAsync();
		_ = Dialog.Add.TextToSpeakAsync("Review your report.");
		await Dialog.PauseAsync();

		await Resolve<Sng_Softec_OpenSafeCityPortal>().ExecuteAsync();
		_ = Dialog.Add.TextToSpeakAsync("Clock out and paste your report");
		await Dialog.PauseAsync();
		
		_ = Dialog.Add.TextToSpeakAsync("You are done.");
		await Dialog.PauseAsync("Exit?");
	}
}