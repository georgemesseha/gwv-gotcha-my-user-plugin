namespace UserPlugin.Workspace.MyTools;

[ManualTrigger("Glyph Search", "Find #fa #material icons images #repo")]
public class Sng_GlyphSearch : SingletonService
{
	public async Task OpenSvgSearchAsync()
	{
		await AddOrActivateWebPageTabAsync("Glyph Search", "https://glyphsearch.com/");	
	}
	
	public override async Task ExecuteAsync()
	{
		await OpenSvgSearchAsync();
		await PauseAsync(); 
	}
}