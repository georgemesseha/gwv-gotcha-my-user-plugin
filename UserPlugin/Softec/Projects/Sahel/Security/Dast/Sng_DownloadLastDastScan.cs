using UserPlugin._GenericServices;

namespace UserPlugin.Softec.Projects.Sahel.Security.Dast;

[ManualTrigger("y4k7v8x", "Download Last Dast Scan", "Downloads the last Dast scan")]
public class Sng_DownloadLastDastScan : SingletonService
{
	protected override async Task ExecuteAsync()
	{
		// await DefaultBrowser.OpenAsync("https://web.analysiscenter.veracode.com");
		Resolve<Trn_Edge>().OpenAsync("https://web.analysiscenter.veracode.com", "veracode", "platform");
		
		await Dialog.Add.InfoAsync("Use the information on the right side, on the page opened in the default browser");

		await Notion.OpenAsync("3566ea6ef608802a997cf2fec0ace815", "Sahell DAST Overview");
		// await Dialog.Add.WebPageAsync("Sahell DAST Overview",
		//                               "https://www.notion.so/Sahell-DAST-3566ea6ef608802a997cf2fec0ace815?source=copy_link");

		await PauseAsync("You're done.");
	}
}