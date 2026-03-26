using Gwv.Gotcha.Services.Plugin;

[ManualTrigger("💼 Gotcha", "Gotcha Project")]
public class Sng_GotchaProject : SingletonService
{
	public override async Task ExecuteAsync()
	{
		Context.Dialog.AddOrActivateSideWebPage("Gotcha Product", 
		                                        "https://www.notion.so/Gotcha-Project-32f6ea6ef608808ea2afed812fa63f5f?source=copy_link");

		
		
		await Context.Dialog.RouteAsync("Then?", true,
		                                      ("Product", typeof(Trn_Gotcha_Product)),
		                                      ("Plugin", typeof(Trn_Gotcha_Plugin))
			                                      );
	}
}