

using UserPlugin._GenericServices.Configuration;

namespace UserPlugin.Softec.Projects.Sahel.Development.Items;

[ManualTrigger("Open Sahel PRs", "Open Sahel pull requests")]
public class Trn_Sahel_OpenPullRequestsPage : TransientService
{
	public override async Task ExecuteAsync()
	{
		var config = Context.Resolve<Sng_Config_Sahel>();
		var prUrl = config.PullRequestsUrl;
		Context.Dialog.AddOrActivateSideWebPage("Sahel PRs", prUrl);
		await Context.Dialog.ShowModalMessageBoxAsync("You're done. Exit?");

	}
}