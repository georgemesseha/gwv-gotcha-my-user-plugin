
[ManualTrigger("💁🏽‍ Knowledge Recall", "Recall #learn #remember how your information are organized")]
public class Sng_KnowledgeRecall : SingletonService
{
	public override async Task ExecuteAsync()
	{
		await Context.Dialog.SpeakAsync("You aimed to have a categorized view of your information while having a way for automatic recalling");
		await Context.Dialog.ShowModalMessageBoxAsync();
		var commonTabs = Context.Resolve<Sng_CommonTabs>();
		Context.Dialog.AddOrActivateSideWebPage(commonTabs.Tab_SoftecAuthProjectMainPage, 
		                                        commonTabs.Url_SoftecAuthProjectMainPage);
		await Context.Dialog.SpeakAsync("Like you did for documenting Auth project, but for knowledge base categorized in a hierarchical manner.");
		await Context.Dialog.ShowModalMessageBoxAsync();
		await Context.Dialog.SpeakAsync("The hierarchy should be implemented in Gotcha");
		
		await Context.Dialog.ShowModalMessageBoxAsync("Done. Exit?");
		Context.Dialog.Dismiss();
	}
}