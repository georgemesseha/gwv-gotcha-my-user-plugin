using UserPlugin._GenericServices;

namespace UserPlugin.Workspace.MyTools;

[ManualTrigger("l3k3y7y", "SVG Search", "Find SVG icons images #repo")]
public class Sng_SvgSearch : SingletonService
{
	public async Task OpenSvgSearchAsync()
	{
		
		await Edge.OpenAsync("https://uxwing.com", "UX Wing", "download", "icons", "svg", "High-Quality");
		await Edge.OpenAsync("https://www.svgrepo.com", "SVG Repo", "svg", "vectors", "icons", "repo");


		// await Dialog.Add.WebPageAsync("UX Wing", "https://uxwing.com");	 
		// await Dialog.Add.WebPageAsync("SVG Search", "https://www.svgrepo.com");	
	}
	
	protected override async Task ExecuteAsync()
	{
		await OpenSvgSearchAsync();
		await PauseAsync(); 
	}
}