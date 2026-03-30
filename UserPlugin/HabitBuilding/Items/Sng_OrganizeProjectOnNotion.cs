
using UserPlugin._GenericServices;

namespace UserPlugin.HabitBuilding.Items;

[ManualTrigger("Habit Builder | Organize a project On Notion", "Recall #learn #remember how to Organize a project On Notion")]
public class Sng_OrganizeProjectOnNotion : SingletonService
{
	public override async Task ExecuteAsync()
	{
		var commonTabs = Context.Resolve<Sng_CommonTabs>();
		Context.Dialog.AddOrActivateSideWebPage(commonTabs.Tab_SoftecAuthProjectMainPage, 
		                                        commonTabs.Url_SoftecAuthProjectMainPage);
		await Context.Dialog.SpeakAsync("You mainly aim to have your clean view of the project like this");
		await Context.Dialog.SpeakAsync("It's actually a filtered view of your main DB");
		await Context.Dialog.ShowModalMessageBoxAsync();
		Context.Dialog.AddOrActivateSideWebPage("Page Sample", 
		                                        "https://www.notion.so/Softec-Auth-Repos-32e6ea6ef60880d88ceacd5b7ae374d4?v=b4be136bb3004fae8eee39279d619d40&source=copy_link");
		
		await Context.Dialog.SpeakAsync("To achieve this, you need to have a tag like (Softec.Auth) for the project assigned to all the pages belongs to the project");
		await Context.Dialog.ShowModalMessageBoxAsync();
		Context.Dialog.AddOrActivateSideWebPage(commonTabs.Tab_SoftecAuthProjectMainPage, "");
		await Context.Dialog.SpeakAsync("Fortunately, you have to do this for the first page, then adding a page from this view, the tag will be added automatically.");
		await Context.Dialog.ShowModalMessageBoxAsync();
		await Context.Dialog.SpeakAsync("Whenever you want to add anything to the project, you pick a page to edit from this DB view, or add a new page by pressing the add button.");
		await Context.Dialog.ShowModalMessageBoxAsync();
		await Context.Dialog.SpeakAsync("In case you are in a hurry, you may add a new page by pressing the '+ New Page' immediately. And it's pretty handy to organize later.");
		await Context.Dialog.ShowModalMessageBoxAsync();
		await Context.Dialog.SpeakAsync("Pressing every page will open it in a popup, making it easy to reorganize later.");
		await Context.Dialog.SpeakAsync("End of habit builder.");
		await Context.Dialog.ShowModalMessageBoxAsync("Completed. Want to dismiss?");
		// Context.Dialog.Dismiss();
		
	}
}