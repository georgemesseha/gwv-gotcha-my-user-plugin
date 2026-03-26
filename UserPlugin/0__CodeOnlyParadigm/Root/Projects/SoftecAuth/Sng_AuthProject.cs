using Gwv.Gotcha.Services.Plugin;

[ManualTrigger("💼 Auth", "Auth Project")]
public class Sng_AuthProject : SingletonService
{
	public override async Task ExecuteAsync()
	{
		var commonTabs = Context.Resolve<Sng_CommonTabs>();
		
		Context.Dialog.AddOrActivateSideWebPage(commonTabs.Tab_SoftecAuthProjectMainPage, 
		                                        commonTabs.Url_SoftecAuthProjectMainPage);


		await Context.Dialog.RouteAsync("Category?", true,
		                                ("Develop", typeof(Sng_AuthProject_Development)));
	}
}