using UserPlugin.Softec.Projects.Sahel.Deployment;
using UserPlugin.Softec.Projects.Sahel.Development;
using UserPlugin.Softec.Projects.Sahel.Requirements;

namespace UserPlugin.Softec.Projects.Sahel;

[ManualTrigger("Overview", "Sahel Project")]
public class Trn_SahelProject : TransientService
{
	public override async Task ExecuteAsync()
	{
		Context.Dialog.AddOrActivateSideWebPage("Sahel Project Overview", "https://www.notion.so/Sahel-Project-32f6ea6ef608803bb780deacf4e51ebf?source=copy_link");
	}
}