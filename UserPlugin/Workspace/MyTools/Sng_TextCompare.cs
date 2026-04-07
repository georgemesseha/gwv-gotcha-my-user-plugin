namespace UserPlugin.Workspace.MyTools;

[ManualTrigger("Compare text", "Compares text")]
public class Sng_TextCompare : SingletonService
{
	public override async Task ExecuteAsync()
	{
		await AddOrActivateWebPageTabAsync("Compare Text", "https://www.diffchecker.com");
		await PauseAsync("You're done");
	}
}