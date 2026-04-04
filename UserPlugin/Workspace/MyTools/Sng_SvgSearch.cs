namespace UserPlugin.Workspace.MyTools;

[ManualTrigger("SVG Search", "Find SVG icons images #repo")]
public class Sng_SvgSearch : SingletonService
{
	public void OpenSvgSearch()
	{
		AddOrActivateWebPageTab("SVG Search", "https://www.svgrepo.com");	
	}
	
	public override async Task ExecuteAsync()
	{
		OpenSvgSearch();
		await PauseAsync(); 
	}
}