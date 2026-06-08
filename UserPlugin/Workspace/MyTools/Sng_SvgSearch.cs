using UserPlugin._GenericServices;

namespace UserPlugin.Workspace.MyTools;

[ManualTrigger("l3k3y7y", "SVG Search", "Find SVG icons images #repo")]
public class Sng_SvgSearch : SingletonService
{
	public async Task OpenSvgSearchAsync()
	{
		
<<<<<<< HEAD
		await Edge.OpenAsync("https://uxwing.com", "UX Wing", "svg"); 
		await Edge.OpenAsync("https://www.svgrepo.com", "SVG Repo", "svg");


		// await Dialog.Add.WebPageAsync("UX Wing", "https://uxwing.com");	 
=======
		Resolve<Trn_Edge>().OpenAsync("https://uxwing.com", "UX Wing");
		Resolve<Trn_Edge>().OpenAsync("https://www.svgrepo.com", "SVG Search");
		
		// await Dialog.Add.WebPageAsync("UX Wing", "https://uxwing.com");	
>>>>>>> 63f549c01880ff908bec2b9b85f35eddacb85880
		// await Dialog.Add.WebPageAsync("SVG Search", "https://www.svgrepo.com");	
	}
	
	protected override async Task ExecuteAsync()
	{
		await OpenSvgSearchAsync();
		await PauseAsync(); 
	}
}