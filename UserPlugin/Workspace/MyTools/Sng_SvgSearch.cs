using UserPlugin._GenericServices;

namespace UserPlugin.Workspace.MyTools;

[ManualTrigger("l3k3y7y", "SVG Search", "Find SVG icons images #repo")]
public class Sng_SvgSearch : SingletonService
{
	public async Task OpenSvgSearchAsync()
	{
		
		Resolve<Trn_Edge>().OpenAsync("https://uxwing.com", "UX Wing");
		Resolve<Trn_Edge>().OpenAsync("https://www.svgrepo.com", "SVG Search");
		
		// await Dialog.Add.WebPageAsync("UX Wing", "https://uxwing.com");	
		// await Dialog.Add.WebPageAsync("SVG Search", "https://www.svgrepo.com");	
	}
	
	protected override async Task ExecuteAsync()
	{
		await OpenSvgSearchAsync();
		await PauseAsync(); 
	}
}