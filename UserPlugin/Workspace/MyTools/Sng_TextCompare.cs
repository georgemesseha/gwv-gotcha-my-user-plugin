using UserPlugin._GenericServices;

namespace UserPlugin.Workspace.MyTools;

[ManualTrigger("d6o1v2f", "Compare text", "Compares text")]
public class Sng_TextCompare : SingletonService
{
	protected override async Task ExecuteAsync()
	{
		await Resolve<Trn_Edge>().OpenAsync("https://www.diffchecker.com", "compare", "text", "find");

		// await Dialog.Add.WebPageAsync("Compare Text", "https://www.diffchecker.com");
		await PauseAsync("You're done");
	}
}