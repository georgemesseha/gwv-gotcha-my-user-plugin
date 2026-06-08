using UserPlugin._GenericServices;

namespace UserPlugin.Workspace.MyTools;

[ManualTrigger("p2a9s1x", "Regex tester", "Opens regex tester")]
public class Sng_RegexTester : SingletonService
{
	protected override async Task ExecuteAsync()
	{
<<<<<<< HEAD
		await Edge.OpenAsync("https://regex101.com", "Regex Tester");
=======
		await Resolve<Trn_Edge>().OpenAsync("https://regex101.com", "regex101");
>>>>>>> 63f549c01880ff908bec2b9b85f35eddacb85880
		
		// await Dialog.Add.WebPageAsync("Regex tester", "https://regex101.com");
		await PauseAsync("Press Enter to exist");
	}
}