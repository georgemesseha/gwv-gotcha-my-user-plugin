
public class Trn_Gotcha_Plugin_GitRepo : TransientService
{
	public override async Task ExecuteAsync()
	{
		var pluginDir = Context.Resolve<Sng_Config_Gotcha>().PluginMainDirPath;
		await Context.Resolve<Sng_OpenInVsCode>().OpenDirectory(pluginDir);
	}
}