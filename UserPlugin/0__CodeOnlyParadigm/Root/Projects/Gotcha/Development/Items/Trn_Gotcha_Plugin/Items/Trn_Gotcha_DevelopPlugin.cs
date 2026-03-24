
[ManualTrigger("Develop Plugin .sln", "Develop Gotcha Plugin solution", false)]
public class Trn_Gotcha_DevelopPlugin : TransientService
{
	public override async Task ExecuteAsync()
	{
		var plugnSlnFilePath = Context.Resolve<Sng_Config_Gotcha>().PluginSlnFilePath;
		await Context.Resolve<Sng_OpenInRider>().OpenSolutionAsync(plugnSlnFilePath);
	}
}