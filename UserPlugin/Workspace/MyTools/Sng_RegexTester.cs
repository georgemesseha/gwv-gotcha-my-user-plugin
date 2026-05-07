namespace UserPlugin.Workspace.MyTools;

[ManualTrigger("p2a9s1x", "Regex tester", "Opens regex tester")]
public class Sng_RegexTester : SingletonService
{
	protected override async Task ExecuteAsync()
	{
		await Dialog.Add.WebPageAsync("Regex tester", "https://regex101.com");
		await Dialog.PauseAsync("Press Enter to exist");
	}
}