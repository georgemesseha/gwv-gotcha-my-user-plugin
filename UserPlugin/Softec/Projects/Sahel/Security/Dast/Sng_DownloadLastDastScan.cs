namespace UserPlugin.Softec.Projects.Sahel.Security.Dast;

[ManualTrigger("Download Last Dast Scan", "Downloads the last Dast scan")]
public class Sng_DownloadLastDastScan : SingletonService
{
	public override async Task ExecuteAsync()
	{
		await Integration.OpenInDefaultBrowserAsync("https://web.analysiscenter.veracode.com");
		await Dialog.Add.InfoAsync("Use the information on the right side, on the page opened in the default browser");
		await Dialog.Add.WebPageAsync("Sahell DAST Overview",
		                              "https://www.notion.so/Sahell-DAST-3566ea6ef608802a997cf2fec0ace815?source=copy_link");

		await Dialog.PauseAsync("You're done.");
	}
}