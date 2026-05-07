using UserPlugin._GenericServices;

namespace UserPlugin.Softec.Projects.Auth;

[ManualTrigger("g9o5l1j", "Overview", "Auth Project Overview")]
public class Sng_Overview : SingletonService
{
	protected override async Task ExecuteAsync()
	{
		var commonTabs = Resolve<Sng_CommonTabs>();
		await Dialog.Add.WebPageAsync(commonTabs.Tab_SoftecAuthProjectMainPage, 
		                              commonTabs.Url_SoftecAuthProjectMainPage);

		await Dialog.PauseAsync();

	}
}