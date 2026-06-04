
using UserPlugin._GenericServices;

namespace UserPlugin.HabitBuilding;

[ManualTrigger("y8f6r7", "Organize a project On Notion", "Recall #learn #remember how to Organize a project On Notion")]
public class Sng_OrganizeProjectOnNotion : SingletonService
{
	protected override async Task ExecuteAsync()
	{
		var commonTabs = Resolve<Sng_CommonTabs>();
		// await Dialog.Add.WebPageAsync(commonTabs.Tab_SoftecAuthProjectMainPage, commonTabs.Url_SoftecAuthProjectMainPage);
		await Notion.OpenAsync("9d397c27567e4490a2d8b98cbe0f4640", commonTabs.Tab_SoftecAuthProjectMainPage);
		
		await Dialog.Add.TextToSpeakAsync("You mainly aim to have your clean view of the project like this");
		await Dialog.Add.TextToSpeakAsync("It's actually a filtered view of your main DB");
		await PauseAsync();
		// await Dialog.Add.WebPageAsync("Page Sample", "https://www.notion.so/Softec-Auth-Repos-32e6ea6ef60880d88ceacd5b7ae374d4?v=b4be136bb3004fae8eee39279d619d40&source=copy_link");
		await Notion.OpenAsync("32e6ea6ef60880d88ceacd5b7ae374d4", "Page Sample");
		
		await Dialog.Add.TextToSpeakAsync("To achieve this, you need to have a tag like (Softec.Auth) for the project assigned to all the pages belongs to the project");
		await PauseAsync();
		// await Dialog.Add.WebPageAsync(commonTabs.Tab_SoftecAuthProjectMainPage, commonTabs.Url_SoftecAuthProjectMainPage);
		await Notion.OpenAsync(commonTabs.SoftecAuthProjectNotionPageId, commonTabs.Tab_SoftecAuthProjectMainPage);
		
		
		await Dialog.Add.TextToSpeakAsync("Fortunately, you have to do this for the first page, then adding a page from this view, the tag will be added automatically.");
		await PauseAsync();
		await Dialog.Add.TextToSpeakAsync("Whenever you want to add anything to the project, you pick a page to edit from this DB view, or add a new page by pressing the add button.");
		await PauseAsync();
		await Dialog.Add.TextToSpeakAsync("In case you are in a hurry, you may add a new page by pressing the '+ New Page' immediately. And it's pretty handy to organize later.");
		await PauseAsync();
		await Dialog.Add.TextToSpeakAsync("Pressing every page will open it in a popup, making it easy to reorganize later.");
		await Dialog.Add.TextToSpeakAsync("End of habit builder.");
		await PauseAsync("Completed. Want to dismiss?");
		// Context.Dialog.Dismiss();
		
	}
}