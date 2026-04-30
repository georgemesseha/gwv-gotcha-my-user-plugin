namespace UserPlugin.Workspace.MyTools;

[ManualTrigger("Compare text", "Compares text")]
public class Sng_TextCompare : SingletonService
{
	public override async Task ExecuteAsync()
	{
		await Dialog.Add.WebPageAsync("Compare Text", "https://www.diffchecker.com");
		await Dialog.PauseAsync("You're done");
	}
}