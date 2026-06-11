using UserPlugin._GenericServices;

namespace UserPlugin.Softec.Projects.Auth;

[ManualTrigger("g9o5l1j", "Overview", "Auth Project Overview")]
public class Sng_Overview : SingletonService
{
	protected override async Task ExecuteAsync()
	{ 
		var commonTabs = Resolve<Sng_CommonTabs>();

		
		await Notion.OpenAsync(commonTabs.NotionId_SoftecAuthProject, commonTabs.Tab_SoftecAuthProjectMainPage);
		
		await Resolve<SessionControlDiagrams>().OpenDiagramAsync();
		await Notion.OpenAsync("https://app.notion.com/p/Softec-Auth-Backlog-3236ea6ef60880ddaf22f07b1bcd4382?source=copy_link",
		                       "Backlog");
		await Notion.OpenAsync("https://app.notion.com/p/Code-Map-3796ea6ef608803fa971e8ee23c08a7b?source=copy_link",
		                       "Code Map");

		await PauseAsync();

	}
}