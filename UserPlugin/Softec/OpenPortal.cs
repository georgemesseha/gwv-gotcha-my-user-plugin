
using UserPlugin._GenericServices;

namespace UserPlugin.Softec;

[ManualTrigger("m0c6i2j0w2g9a3")]
public class OpenPortal : SingletonService  
{
    protected override async Task ExecuteAsync()
	{
		// await DefaultBrowser.OpenAsync("notion://app.notion.com/new");
		
        //notion://app.notion.com/p/Create-a-DbContext-for-code-first-approach-3726ea6ef60880179c0cc90247680d01?source=copy_link
		// await DefaultBrowser.OpenAsync("https://safecityportal.com/stream/");
		await Resolve<Sng_SafeCity>().OpenPortalPwaAsync();

		await PauseAsync();
	}
}