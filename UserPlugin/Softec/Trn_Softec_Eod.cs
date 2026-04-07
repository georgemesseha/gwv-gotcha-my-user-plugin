
using UserPlugin._GenericServices;

namespace UserPlugin.Softec;

[ManualTrigger("🌇 EOD", "End of day actions")]
public class Trn_Softec_Eod : TransientService
{
	public override async Task ExecuteAsync()
	{
		var commonTabs = Resolve<Sng_CommonTabs>();
		
		await AddOrActivateWebPageTabAsync(commonTabs.Tab_ChatGPT, commonTabs.Url_ChatGPT);
		await AddOrActivateWebPageTabAsync(commonTabs.Tab_SafeCityPortal, commonTabs.Url_SafeCityPortal);
		await AddOrActivateWebPageTabAsync(commonTabs.Tab_SaaedDailyReport, commonTabs.Url_SaaedDailyReport);
		

		_ = SpeakAsync("Prepare your report then resume the conversation.");
		await PauseAsync();
		_ = SpeakAsync("Copy your report.");
		await PauseAsync();
		_ = SpeakAsync("Let ChatGPT polish your report!");
		await AddOrActivateWebPageTabAsync(commonTabs.Tab_ChatGPT, commonTabs.Url_ChatGPT);
		await PauseAsync();
		_ = SpeakAsync("Update the polished report in your Notion page.");
		await AddOrActivateWebPageTabAsync(commonTabs.Tab_SaaedDailyReport, commonTabs.Url_SaaedDailyReport);
		await PauseAsync();
		_ = SpeakAsync("Review your report.");
		await PauseAsync();

		await Resolve<Sng_Softec_OpenSafeCityPortal>().ExecuteAsync();
		_ = SpeakAsync("Clock out and paste your report");
		await PauseAsync();
		
		_ = SpeakAsync("You are done.");
		await PauseAsync("Exit?");
	}
}