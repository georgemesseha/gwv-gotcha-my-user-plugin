
using UserPlugin._GenericServices;

namespace UserPlugin.Softec;

[ManualTrigger("m0c6i2j0w2g9a3")]
public class OpenPortal : SingletonService  
{
    protected override async Task ExecuteAsync()
	{
		await Resolve<Sng_SafeCity>().OpenPortalPwaAsync();
		await DefaultBrowser.OpenAsync("https://safecityportal.com/stream/");

		await PauseAsync();
	}
}