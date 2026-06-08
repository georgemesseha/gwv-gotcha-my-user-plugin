using UserPlugin._GenericServices;

namespace UserPlugin.Workspace.MyTools;

[ManualTrigger("v3f4y2j", "Glyph Search", "Find #fa #material icons images #repo")]
public class Sng_GlyphSearch : SingletonService
{
	public async Task OpenSvgSearchAsync()
	{
		// await DefaultBrowser.OpenAsync("https://glyphsearch.com/");
<<<<<<< HEAD
		await Edge.OpenAsync("https://glyphsearch.com/",  "Glyph Search");
		// await Dialog.Add.WebPageAsync("Glyph Search", "https://glyphsearch.com/");	
		await PauseAsync();
=======
		Resolve<Trn_Edge>().OpenAsync("https://glyphsearch.com/", "Glyph Search");
		// await Dialog.Add.WebPageAsync("Glyph Search", "https://glyphsearch.com/");	
>>>>>>> 63f549c01880ff908bec2b9b85f35eddacb85880
	}
	
	protected override async Task ExecuteAsync()
	{
		await OpenSvgSearchAsync();
		// await PauseAsync(); 
	}
}