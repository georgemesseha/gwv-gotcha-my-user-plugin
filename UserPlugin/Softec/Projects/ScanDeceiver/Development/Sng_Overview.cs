namespace UserPlugin.Softec.Projects.ScanDeciever.Development;

[ManualTrigger("Overview", "Develop ScanDeceiver Project overview")]
public class Sng_Overview : SingletonService
{
	public override async Task ExecuteAsync()
	{
		AddOrActivateWebPageTab("Develop", "https://www.notion.so/Develop-3356ea6ef608809f98ffcd8369749312?v=32e6ea6ef608805cbd14000cf1cb5b33&source=copy_link");
		await RouteAsync("Action?", false,
		                 ("Open Solution", typeof(Sng_OpenSolution))
		                );
	}
} 