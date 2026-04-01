namespace UserPlugin.Softec.Projects.ScanDeciever.Publishing;

[ManualTrigger("Overview", "Publish ScanDeceiver Project overview")]
public class Sng_Overview : SingletonService
{
	public async override Task ExecuteAsync()
	{
		AddSideWebPage("Publish", "https://www.notion.so/Publish-3356ea6ef60880c3bf5ef2e74aa21f28?v=32e6ea6ef608805cbd14000cf1cb5b33&source=copy_link");
		await PauseAsync("You're done");
	}
}