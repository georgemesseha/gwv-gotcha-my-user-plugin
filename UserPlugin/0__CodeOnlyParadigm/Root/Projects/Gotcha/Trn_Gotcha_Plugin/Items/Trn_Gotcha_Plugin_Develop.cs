
public class Trn_Gotcha_Plugin_Develop : TransientService
{
	public override async Task ExecuteAsync()
	{
		var plugnSlnFilePath = Context.Resolve<Sng_Config_Gotcha>().PluginSlnFilePath;
		await Context.Resolve<Sng_OpenInRider>().OpenSolutionAsync(plugnSlnFilePath);
	}
}