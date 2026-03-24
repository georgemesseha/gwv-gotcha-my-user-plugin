
[ManualTrigger("Manage Gotcha Plugin Git repo", "Manage Gotcha Plugin Git repo", false)]
public class Trn_Gotcha_ManagePluginGitRepo : TransientService
{
	public override async Task ExecuteAsync()
	{
		var pluginDir = Context.Resolve<Sng_Config_Gotcha>().PluginMainDirPath;
		await Context.Resolve<Sng_OpenInVsCode>().OpenDirectory(pluginDir);
	}
}