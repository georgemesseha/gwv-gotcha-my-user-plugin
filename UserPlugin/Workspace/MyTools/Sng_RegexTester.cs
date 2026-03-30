namespace UserPlugin.Workspace.MyTools;

[ManualTrigger("Regex tester", "Opens regex tester")]
public class Sng_RegexTester : SingletonService
{
	public override async Task ExecuteAsync()
	{
		Context.Dialog.AddOrActivateSideWebPage("Regex tester", "https://regex101.com");
		await Context.Dialog.ShowModalMessageBoxAsync("Press Enter to exist");
	}
}