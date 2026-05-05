namespace UserPlugin.Workspace.MyTools;

[ManualTrigger("Who is domain/IP", "Get WhoIs info for an IP or domain")]
public class Sng_WhoIsIpOrDomain : SingletonService
{
	protected override async Task ExecuteAsync()
	{
		await Dialog.Add.InfoAsync("Opening whois in default browser");
		await Dialog.Add.WebPageAsync("Who is?", "https://whatismyipaddress.com");
		await Dialog.PauseAsync(); 
	}
}