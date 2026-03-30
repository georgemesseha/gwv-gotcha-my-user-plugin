namespace UserPlugin.Workspace.MyTools;

[ManualTrigger("Compare text", "Compares text")]
public class Sng_TextCompare : SingletonService
{
	public override async Task ExecuteAsync()
	{
		Context.Dialog.AddOrActivateSideWebPage("Compare Text", "https://www.diffchecker.com");
		await Context.Dialog.ShowModalMessageBoxAsync("You're done");
	}
}