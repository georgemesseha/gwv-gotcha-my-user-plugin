using UserPlugin._GenericServices;

namespace UserPlugin.Workspace.MyTools;

[ManualTrigger("p2a9s1x", "Regex tester", "Opens regex tester")]
public class Sng_RegexTester : SingletonService
{
	protected override async Task ExecuteAsync()
	{
		await Edge.OpenAsync("https://regex101.com", "Regex Tester");
		
		// await Dialog.Add.WebPageAsync("Regex tester", "https://regex101.com");
		await PauseAsync("Press Enter to exist");
	}
}