namespace UserPlugin.Workspace.MyTools;

[ManualTrigger("Json viewer", "Opens json viewer")]
public class Sng_JsonViewer : SingletonService
{
	protected override async Task ExecuteAsync()
	{
		await Dialog.Add.WebPageAsync("Json viewer", "https://jsoneditoronline.org/#left=local.kezuqa");
		await Dialog.PauseAsync("Press Enter to exit");
	}
}