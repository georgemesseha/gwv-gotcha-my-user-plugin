

[ManualTrigger("Open Sahel PRs", "Open Sahel pull requests")]
public class Trn_Sahel_OpenPullRequestsPage : TransientService
{
	public override async Task ExecuteAsync()
	{
		var config = Context.Resolve<Sng_Config_Sahel>();
		var prUrl = config.PullRequestsUrl;
		Context.Dialog.AddOrActivateSideWebPage("Sahel PRs", prUrl);
		
	}
}