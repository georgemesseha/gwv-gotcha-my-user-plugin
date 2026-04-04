namespace UserPlugin.Workspace.MyTools;

[ManualTrigger("Regex tester", "Opens regex tester")]
public class Sng_RegexTester : SingletonService
{
	public override async Task ExecuteAsync()
	{
		AddOrActivateWebPageTab("Regex tester", "https://regex101.com");
		await PauseAsync("Press Enter to exist");
	}
}