namespace UserPlugin.Workspace.MyTools;

[ManualTrigger("Json viewer", "Opens json viewer")]
public class Sng_JsonViewer : SingletonService
{
	public override async Task ExecuteAsync()
	{
		Context.Dialog.AddOrActivateSideWebPage("Json viewer", "https://jsoneditoronline.org/#left=local.kezuqa");
		await Context.Dialog.ShowModalMessageBoxAsync("Press Enter to exit");
	}
}