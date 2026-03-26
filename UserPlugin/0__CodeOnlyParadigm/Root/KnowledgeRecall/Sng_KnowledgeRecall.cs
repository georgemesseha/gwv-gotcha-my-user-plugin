
[ManualTrigger("💁🏽‍ Knowledge Recall", "Recall #learn #remember how your information are organized")]
public class Sng_KnowledgeRecall : SingletonService
{
	public override async Task ExecuteAsync()
	{
		var commonTabs = Context.Resolve<Sng_CommonTabs>();
		
		await Context.Dialog.SpeakAsync("Your goal is to have a categorized view of your information hierarchically");
		await Context.Dialog.ShowModalMessageBoxAsync();
		await Context.Dialog.SpeakAsync("You need as well an automatic way for recalling the information");
		await Context.Dialog.ShowModalMessageBoxAsync();
		
		Context.Dialog.AddOrActivateSideWebPage(commonTabs.Tab_SoftecAuthProjectMainPage, 
		                                        commonTabs.Url_SoftecAuthProjectMainPage);

		await Context.Dialog.SpeakAsync("Like you did for documenting Auth project, but the knowledge base should be categorized in a hierarchical manner.");
		await Context.Dialog.ShowModalMessageBoxAsync();
		await Context.Dialog.SpeakAsync("The hierarchy should be implemented in Gotcha's Plug-in");
		
		await Context.Dialog.ShowModalMessageBoxAsync("Done. Exit?");
		// Context.Dialog.Dismiss();
	}
}