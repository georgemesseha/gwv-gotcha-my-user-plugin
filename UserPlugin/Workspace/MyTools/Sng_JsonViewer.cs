namespace UserPlugin.Workspace.MyTools;

[ManualTrigger("Json viewer", "Opens json viewer")]
public class Sng_JsonViewer : SingletonService
{
	public override async Task ExecuteAsync()
	{
		AddOrActivateWebPageTab("Json viewer", "https://jsoneditoronline.org/#left=local.kezuqa");
		await PauseAsync("Press Enter to exit");
	}
}