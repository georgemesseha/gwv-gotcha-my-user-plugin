
using UserPlugin._GenericServices;

namespace UserPlugin.Softec;

public class Sng_Softec_OpenSafeCityPortal : SingletonService
{
	public async Task OpenAsync()
	{
		var commonTabs = Resolve<Sng_CommonTabs>();
		await Dialog.Add.WebPageAsync(commonTabs.Tab_SafeCityPortal, commonTabs.Url_SafeCityPortal);		
	}
}