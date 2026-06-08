

using UserPlugin._GenericServices;
using UserPlugin._GenericServices.Configuration;

namespace UserPlugin.Softec.Projects.Sahel.Development;

[ManualTrigger("j2d2i5f", "Open PRs", "Open Sahel pull requests")]
public class Trn_Sahel_OpenPullRequestsPage : TransientService
{
	protected override async Task ExecuteAsync()
	{
		var config = Resolve<Sng_Config_Sahel>();
		var prUrl = config.PullRequestsUrl;
		// await Dialog.Add.WebPageAsync("Sahel PRs", prUrl);
<<<<<<< HEAD

		
		await Edge.OpenAsync(prUrl, "Sahel PRs");
=======
		
		Resolve<Trn_Edge>().OpenAsync(prUrl);
>>>>>>> 63f549c01880ff908bec2b9b85f35eddacb85880
		
		await PauseAsync("You're done. Exit?");

	}
}