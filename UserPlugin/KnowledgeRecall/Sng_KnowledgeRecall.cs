
using UserPlugin._GenericServices;

namespace UserPlugin.KnowledgeRecall;

[ManualTrigger("💁🏽‍ Knowledge Recall", "Recall #learn #remember how your information are organized")]
public class Sng_KnowledgeRecall : SingletonService
{
	public override async Task ExecuteAsync()
	{
		var commonTabs = Resolve<Sng_CommonTabs>();
		
		await Dialog.Add.TextToSpeakAsync("Your goal is to have a categorized view of your information hierarchically");
		await Dialog.PauseAsync("Done?");
		await Dialog.Add.TextToSpeakAsync("You need as well an automatic way for recalling the information");
		await Dialog.PauseAsync("Done?");
		
		await Dialog.Add.WebPageAsync(commonTabs.Tab_SoftecAuthProjectMainPage, 
		               commonTabs.Url_SoftecAuthProjectMainPage);

		await Dialog.Add.TextToSpeakAsync("Like you did for documenting Auth project, but the knowledge base should be categorized in a hierarchical manner.");
		await Dialog.PauseAsync();
		await Dialog.Add.TextToSpeakAsync("The hierarchy navigation to actions should be implemented in Gotcha's Plug-in");
		
		await Dialog.PauseAsync("Done. Exit?");
		// Context.Dialog.Dismiss();
	}
}