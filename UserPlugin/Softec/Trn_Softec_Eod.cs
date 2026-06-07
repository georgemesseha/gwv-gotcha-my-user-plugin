
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
		await OpenDailyReportDraftAsync();

		_ = Dialog.Add.TextToSpeakAsync("Prepare your report then resume the conversation.");
		await PauseAsync();
		_ = Dialog.Add.TextToSpeakAsync("Copy your report."); 
		await PauseAsync();
		_ = Dialog.Add.TextToSpeakAsync("Let ChatGPT polish your report!");
		
		
		await Edge.OpenAsync(Resolve<Sng_CommonTabs>().Url_ChatGPT, "Chat GPT > Refine report", "chat", "gpt");
		
		await PauseAsync();
		_ = Dialog.Add.TextToSpeakAsync("Update the polished report in your Notion page.");

		await OpenDailyReportDraftAsync();
		
		await PauseAsync();
		_ = Dialog.Add.TextToSpeakAsync("Review your report.");
		await PauseAsync();

		await OpenPortalAsync();
		_ = Dialog.Add.TextToSpeakAsync("Clock out and paste your report");
		await PauseAsync();
		
		_ = Dialog.Add.TextToSpeakAsync("You are done.");
		await PauseAsync("Exit?");
	}
}