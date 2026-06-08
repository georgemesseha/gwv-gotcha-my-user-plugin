using UserPlugin._GenericServices;

namespace UserPlugin.Workspace.MyTools;

[ManualTrigger("a9g7a8b", "Who is domain/IP", "Get WhoIs info for an IP or domain")]
public class Sng_WhoIsIpOrDomain : SingletonService
{
	protected override async Task ExecuteAsync()
	{
		await Dialog.Add.InfoAsync("Opening whois in default browser");
		
<<<<<<< HEAD
		await Edge.OpenAsync("https://whatismyipaddress.com", "What is My IP?");
=======
		await Resolve<Trn_Edge>().OpenAsync("https://whatismyipaddress.com", "what", "ip", "address");
>>>>>>> 63f549c01880ff908bec2b9b85f35eddacb85880
		
		// await Dialog.Add.WebPageAsync("Who is?", "https://whatismyipaddress.com");
		await PauseAsync(); 
	}
}