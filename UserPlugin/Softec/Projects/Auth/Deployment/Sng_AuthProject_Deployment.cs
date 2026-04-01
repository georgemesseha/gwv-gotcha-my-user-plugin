
using UserPlugin._GenericServices;

namespace UserPlugin.Softec.Projects.Auth.Deployment;

public class Sng_AuthProject_Deployment : SingletonService
{

	public override async Task ExecuteAsync()
	{
		var commonTabs = Resolve<Sng_CommonTabs>();
		AddSideWebPage(commonTabs.Tab_SoftecAuthProjectMainPage, 
		               commonTabs.Url_SoftecAuthProjectMainPage);
		
	}
}