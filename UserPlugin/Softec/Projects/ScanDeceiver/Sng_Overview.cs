namespace UserPlugin.Softec.Projects.ScanDeceiver;

[ManualTrigger("Overview", "ScanDeceiver Project #veracode #ips")]
public class Sng_Overview : SingletonService
{
	public override async Task ExecuteAsync()
	{
		await AddOrActivateWebPageTabAsync("ScanDeceiver Project", "https://www.notion.so/Scan-Deceiver-Project-3356ea6ef60880ed9483c97f790e40d2?v=32e6ea6ef608805cbd14000cf1cb5b33&source=copy_link");

		await RouteAsync("Action?", false,
		                 ("Develop", typeof(Development.Sng_Overview)),
		                 ("Publish", typeof(Publishing.Sng_Overview))
		                );
	}
}