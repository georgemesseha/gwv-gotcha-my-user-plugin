using UserPlugin._GenericServices;

namespace UserPlugin.Workspace.MyTools;

[ManualTrigger("d6o1v2f", "Compare text", "Compares text")]
public class Sng_TextCompare : SingletonService
{
	protected override async Task ExecuteAsync()
	{
		await Edge.OpenAsync("https://www.diffchecker.com", "Compare Text");
		await PauseAsync("You're done");
	}
}