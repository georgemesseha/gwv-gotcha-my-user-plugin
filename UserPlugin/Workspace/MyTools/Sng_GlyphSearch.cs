namespace UserPlugin.Workspace.MyTools;

[ManualTrigger("Glyph Search", "Find #fa #material icons images #repo")]
public class Sng_GlyphSearch : SingletonService
{
	public void OpenSvgSearch()
	{
		AddOrActivateWebPageTab("Glyph Search", "https://glyphsearch.com/");	
	}
	
	public override async Task ExecuteAsync()
	{
		OpenSvgSearch();
		await PauseAsync(); 
	}
}