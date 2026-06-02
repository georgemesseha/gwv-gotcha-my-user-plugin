using UserPlugin._GenericServices;
using UserPlugin.Softec.Projects.Sahel.Deployment;
using UserPlugin.Softec.Projects.Sahel.Development;
using UserPlugin.Softec.Projects.Sahel.Requirements;

namespace UserPlugin.Softec.Projects.Sahel;

[ManualTrigger("w4e1c7l", "Overview", "Sahel Project")]
public class Trn_Overview : TransientService
{
	protected override async Task ExecuteAsync()
	{
		await Resolve<Sng_Notion>().GrabNotion("32f6ea6ef608803bb780deacf4e51ebf", "Sahel Project Overview");
		// await Dialog.Add.WebPageAsync("Sahel Project Overview", "https://www.notion.so/Sahel-Project-32f6ea6ef608803bb780deacf4e51ebf?source=copy_link");
		await PauseAsync("Press Enter to exit");
	}

	private Task FallbackAction()
	{
		throw new NotImplementedException();
	}
	
}