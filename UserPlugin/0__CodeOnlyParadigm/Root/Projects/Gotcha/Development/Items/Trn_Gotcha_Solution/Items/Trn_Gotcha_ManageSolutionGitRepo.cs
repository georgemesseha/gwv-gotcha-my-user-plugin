
[ManualTrigger("Manage Gotcha Solution Git repo", "Manage Gotcha Solution Git repo", false)]
public class Trn_Gotcha_ManageSolutionGitRepo : TransientService
{
	public override async Task ExecuteAsync()
	{
		var gotchaMainDirPath = Context.Resolve<Sng_Config_Gotcha>().GotchaMainDirPath;
		await Context.Resolve<Sng_OpenInVsCode>()
		             .OpenDirectory(gotchaMainDirPath);
	}
}