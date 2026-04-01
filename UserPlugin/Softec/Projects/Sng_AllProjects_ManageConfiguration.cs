using UserPlugin._GenericServices;
using UserPlugin._GenericServices.Configuration;

namespace UserPlugin.Softec.Projects;

[ManualTrigger("⚙️ Open deployment configuration repo", "Manage Sahel, Zimbabwe, and other projects' configurations")]
public class Sng_AllProjects_ManageConfiguration : SingletonService
{
	public override async Task ExecuteAsync()
	{
		var sngRider = Resolve<Sng_OpenInRider>();
		var sngConfig = Resolve<Sng_Config_Sahel>();
		
		AddSideWebPage("Projects Configuration", "https://www.notion.so/Softec-Projects-Configuration-32e6ea6ef608804ab252c1eca64c2dc9?source=copy_link");
		await sngRider.OpenDirectoryAsync(sngConfig.ConfigurationProjectDir);
		await SpeakAsync("Configuration project is opening?");
		await SpeakAsync("Find a dedicated info page on the left. Edit it for augmenting knowledge when possible");

		await PauseAsync("You're done. Dismiss?");
		// Context.Dialog.Dismiss();
		
	}
}