using Gwv.Gotcha.Services.Plugin;

[ManualTrigger("💼 Auth", "Auth Project")]
public class Sng_AuthProject : SingletonService
{
	public override async Task ExecuteAsync()
	{
		var commonTabs = Context.Resolve<Sng_CommonTabs>();
		Context.Dialog.AddOrActivateSideWebPage(commonTabs.Tab_SoftecAuthProjectMainPage, 
		                                        commonTabs.Url_SoftecAuthProjectMainPage);

		while (true)
		{
			var service
				= await Context.Dialog.PickServiceAsync("Category?",
				                                        ("Develop", typeof(Sng_AuthProject_Development)),
				                                        ("I'm done", typeof(Trn_Exit))
				                                       );
			switch (service)
			{
				case Trn_Exit iamDone:
					await iamDone.ExecuteAsync();
					return;
			}
			await service.ExecuteAsync();
		}
	}
}