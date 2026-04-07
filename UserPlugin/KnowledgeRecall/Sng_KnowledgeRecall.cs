
using UserPlugin._GenericServices;

namespace UserPlugin.KnowledgeRecall;

[ManualTrigger("💁🏽‍ Knowledge Recall", "Recall #learn #remember how your information are organized")]
public class Sng_KnowledgeRecall : SingletonService
{
	public override async Task ExecuteAsync()
	{
		var commonTabs = Resolve<Sng_CommonTabs>();
		
		await SpeakAsync("Your goal is to have a categorized view of your information hierarchically");
		await PauseAsync("Done?");
		await SpeakAsync("You need as well an automatic way for recalling the information");
		await PauseAsync("Done?");
		
		await AddOrActivateWebPageTabAsync(commonTabs.Tab_SoftecAuthProjectMainPage, 
		               commonTabs.Url_SoftecAuthProjectMainPage);

		await SpeakAsync("Like you did for documenting Auth project, but the knowledge base should be categorized in a hierarchical manner.");
		await PauseAsync();
		await SpeakAsync("The hierarchy navigation to actions should be implemented in Gotcha's Plug-in");
		
		await PauseAsync("Done. Exit?");
		// Context.Dialog.Dismiss();
	}
}