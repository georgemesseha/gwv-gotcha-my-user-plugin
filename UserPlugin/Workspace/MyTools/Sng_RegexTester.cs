namespace UserPlugin.Workspace.MyTools;

[ManualTrigger("Regex tester", "Opens regex tester")]
public class Sng_RegexTester : SingletonService
{
	public override async Task ExecuteAsync()
	{
		await AddOrActivateWebPageTabAsync("Regex tester", "https://regex101.com");
		await PauseAsync("Press Enter to exist");
	}
}