namespace UserPlugin.Workspace.MyTools;

[ManualTrigger("q1b3d9g", "Is Down For Me Only", "Opens the website to check if a website is down for just me")]
public class Sng_IsDownForMeOnly : SingletonService
{
	protected override Task ExecuteAsync()
	{
			
		_ = DefaultBrowser.OpenAsync("https://downforeveryoneorjustme.com");
		return Task.CompletedTask; 
	}
}