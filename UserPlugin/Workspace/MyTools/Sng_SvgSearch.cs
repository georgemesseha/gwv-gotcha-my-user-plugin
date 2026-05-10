namespace UserPlugin.Workspace.MyTools;

[ManualTrigger("l3k3y7y", "SVG Search", "Find SVG icons images #repo")]
public class Sng_SvgSearch : SingletonService
{
	public async Task OpenSvgSearchAsync()
	{
		
		await Dialog.Add.WebPageAsync("UX Wing", "https://uxwing.com");	
		await Dialog.Add.WebPageAsync("SVG Search", "https://www.svgrepo.com");	
	}
	
	protected override async Task ExecuteAsync()
	{
		await OpenSvgSearchAsync();
		await Dialog.PauseAsync(); 
	}
}