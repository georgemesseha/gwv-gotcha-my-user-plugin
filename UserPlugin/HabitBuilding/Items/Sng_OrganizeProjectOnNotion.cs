
using UserPlugin._GenericServices;

namespace UserPlugin.HabitBuilding.Items;

[ManualTrigger("Organize a project On Notion", "Recall #learn #remember how to Organize a project On Notion")]
public class Sng_OrganizeProjectOnNotion : SingletonService
{
	public override async Task ExecuteAsync()
	{
		var commonTabs = Resolve<Sng_CommonTabs>();
		AddOrActivateWebPageTab(commonTabs.Tab_SoftecAuthProjectMainPage, commonTabs.Url_SoftecAuthProjectMainPage);
		await SpeakAsync("You mainly aim to have your clean view of the project like this");
		await SpeakAsync("It's actually a filtered view of your main DB");
		await PauseAsync();
		AddOrActivateWebPageTab("Page Sample", "https://www.notion.so/Softec-Auth-Repos-32e6ea6ef60880d88ceacd5b7ae374d4?v=b4be136bb3004fae8eee39279d619d40&source=copy_link");
		
		await SpeakAsync("To achieve this, you need to have a tag like (Softec.Auth) for the project assigned to all the pages belongs to the project");
		await PauseAsync();
		AddOrActivateWebPageTab(commonTabs.Tab_SoftecAuthProjectMainPage, commonTabs.Url_SoftecAuthProjectMainPage);
		await SpeakAsync("Fortunately, you have to do this for the first page, then adding a page from this view, the tag will be added automatically.");
		await PauseAsync();
		await SpeakAsync("Whenever you want to add anything to the project, you pick a page to edit from this DB view, or add a new page by pressing the add button.");
		await PauseAsync();
		await SpeakAsync("In case you are in a hurry, you may add a new page by pressing the '+ New Page' immediately. And it's pretty handy to organize later.");
		await PauseAsync();
		await SpeakAsync("Pressing every page will open it in a popup, making it easy to reorganize later.");
		await SpeakAsync("End of habit builder.");
		await PauseAsync("Completed. Want to dismiss?");
		// Context.Dialog.Dismiss();
		
	}
}