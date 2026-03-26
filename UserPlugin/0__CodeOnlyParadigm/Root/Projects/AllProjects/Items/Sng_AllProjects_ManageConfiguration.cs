
[ManualTrigger("⚙️ Open projects configuration repo", "Manage Sahel, Zimbabwe, and other projects' configurations")]
public class Sng_AllProjects_ManageConfiguration : SingletonService
{
	public override async Task ExecuteAsync()
	{
		var sngRider = Context.Resolve<Sng_OpenInRider>();
		var sngConfig = Context.Resolve<Sng_Config_Sahel>();
		
		Context.Dialog.AddOrActivateSideWebPage("Projects Configuration", "https://www.notion.so/Softec-Projects-Configuration-32e6ea6ef608804ab252c1eca64c2dc9?source=copy_link");
		await sngRider.OpenDirectory(sngConfig.ConfigurationProjectDir);
		await Context.Dialog.SpeakAsync("Configuration project is opening?");
		await Context.Dialog.SpeakAsync("Find a dedicated info page on the left. Edit it for augmenting knowledge when possible");

		await Context.Dialog.ShowModalMessageBoxAsync("You're done. Dismiss?");
		// Context.Dialog.Dismiss();
		
	}
}