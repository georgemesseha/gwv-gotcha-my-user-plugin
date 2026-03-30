
using UserPlugin._GenericServices;

namespace UserPlugin.Softec;

public class Sng_Softec_OpenSafeCityPortal : SingletonService
{
	public override async Task ExecuteAsync()
	{
		var commonTabs = Context.Resolve<Sng_CommonTabs>();
		Context.Dialog.AddOrActivateSideWebPage(commonTabs.Tab_SafeCityPortal, commonTabs.Url_SafeCityPortal);		
	}
}