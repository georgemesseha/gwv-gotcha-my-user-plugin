

using UserPlugin._GenericServices.Configuration;

namespace UserPlugin.Softec.Projects.Sahel.Development;

[ManualTrigger("Open PRs", "Open Sahel pull requests")]
public class Trn_Sahel_OpenPullRequestsPage : TransientService
{
	public override async Task ExecuteAsync()
	{
		var config = Resolve<Sng_Config_Sahel>();
		var prUrl = config.PullRequestsUrl;
		await Dialog.Add.WebPageAsync("Sahel PRs", prUrl);
		await Dialog.PauseAsync("You're done. Exit?");

	}
}