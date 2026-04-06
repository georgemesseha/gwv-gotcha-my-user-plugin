namespace UserPlugin.Workspace.MyTools;

[ManualTrigger("Is Down For Me Only", "Opens the website to check if a website is down for just me")]
public class Sng_IsDownForMeOnly : SingletonService
{
	public override Task ExecuteAsync()
	{
		OpenInDefaultBrowser("https://downforeveryoneorjustme.com");
		return Task.CompletedTask;
	}
}