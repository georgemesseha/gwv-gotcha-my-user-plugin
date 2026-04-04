
using UserPlugin._GenericServices;

namespace UserPlugin.Softec;

public class Sng_Softec_OpenSafeCityPortal : SingletonService
{
	public override async Task ExecuteAsync()
	{
		var commonTabs = Resolve<Sng_CommonTabs>();
		AddOrActivateWebPageTab(commonTabs.Tab_SafeCityPortal, commonTabs.Url_SafeCityPortal);		
	}
}