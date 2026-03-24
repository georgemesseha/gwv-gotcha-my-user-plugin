

using Gwv.Gotcha.Services.Plugin;

[ManualTrigger("Open Sahel sln in  Rider", 
               "Open Sahel backend solution in Rider",
               false)]

public class Trn_Sahel_Rider_OpenSln : TransientService
{
	public override async Task ExecuteAsync()
	{
		var config = Context.Resolve<Sng_Config_Sahel>();
		var openInRider = Context.Resolve<Sng_OpenInRider>();
		await openInRider.OpenSolutionAsync(config.SlnFilePath);
	}
}