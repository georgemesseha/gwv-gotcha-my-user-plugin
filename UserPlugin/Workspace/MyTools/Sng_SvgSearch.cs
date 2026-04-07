namespace UserPlugin.Workspace.MyTools;

[ManualTrigger("SVG Search", "Find SVG icons images #repo")]
public class Sng_SvgSearch : SingletonService
{
	public async Task OpenSvgSearchAsync()
	{
		await AddOrActivateWebPageTabAsync("SVG Search", "https://www.svgrepo.com");	
	}
	
	public override async Task ExecuteAsync()
	{
		await OpenSvgSearchAsync();
		await PauseAsync(); 
	}
}