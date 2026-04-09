namespace UserPlugin.Softec.Projects.ScanDeceiver.Publishing;

[ManualTrigger("Overview", "Publish ScanDeceiver Project overview")]
public class Sng_Overview : SingletonService
{
	public async override Task ExecuteAsync()
	{
		await AddOrActivateWebPageTabAsync("Publish", "https://www.notion.so/Scan-Deceiver-Project-3356ea6ef60880ed9483c97f790e40d2?source=copy_link");
		await PauseAsync("You're done");
	}
}