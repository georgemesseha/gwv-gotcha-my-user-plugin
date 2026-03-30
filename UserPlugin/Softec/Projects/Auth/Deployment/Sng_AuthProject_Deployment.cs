
using UserPlugin._GenericServices;

namespace UserPlugin.Softec.Projects.Auth;

public class Sng_AuthProject_Deployment : SingletonService
{

	public override async Task ExecuteAsync()
	{
		var commonTabs = Context.Resolve<Sng_CommonTabs>();
		Context.Dialog.AddOrActivateSideWebPage(commonTabs.Tab_SoftecAuthProjectMainPage, 
		                                        commonTabs.Url_SoftecAuthProjectMainPage);
		
	}
}