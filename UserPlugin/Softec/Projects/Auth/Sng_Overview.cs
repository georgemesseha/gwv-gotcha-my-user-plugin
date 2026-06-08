using UserPlugin._GenericServices;

namespace UserPlugin.Softec.Projects.Auth;

[ManualTrigger("g9o5l1j", "Overview", "Auth Project Overview")]
public class Sng_Overview : SingletonService
{
	protected override async Task ExecuteAsync()
	{ 
		var commonTabs = Resolve<Sng_CommonTabs>();
		
<<<<<<< HEAD
		await Notion.OpenAsync(commonTabs.NotionId_SoftecAuthProject, commonTabs.Tab_SoftecAuthProjectMainPage);
=======
		await Resolve<Sng_Notion>().GrabNotion(commonTabs.NotionId_SoftecAuthProject, commonTabs.Tab_SoftecAuthProjectMainPage);
>>>>>>> 63f549c01880ff908bec2b9b85f35eddacb85880
		// await Dialog.Add.WebPageAsync(commonTabs.Tab_SoftecAuthProjectMainPage, 
		//                               commonTabs.Url_SoftecAuthProjectMainPage);

		await PauseAsync();

	}
}