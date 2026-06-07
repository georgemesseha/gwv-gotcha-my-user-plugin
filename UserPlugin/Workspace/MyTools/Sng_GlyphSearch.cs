using UserPlugin._GenericServices;

namespace UserPlugin.Workspace.MyTools;

[ManualTrigger("v3f4y2j", "Glyph Search", "Find #fa #material icons images #repo")]
public class Sng_GlyphSearch : SingletonService
{
	public async Task OpenSvgSearchAsync()
	{
		// await DefaultBrowser.OpenAsync("https://glyphsearch.com/");
		await Edge.OpenAsync("https://glyphsearch.com/",  "Glyph Search");
		// await Dialog.Add.WebPageAsync("Glyph Search", "https://glyphsearch.com/");	
		await PauseAsync();
	}
	
	protected override async Task ExecuteAsync()
	{
		await OpenSvgSearchAsync();
		// await PauseAsync(); 
	}
}