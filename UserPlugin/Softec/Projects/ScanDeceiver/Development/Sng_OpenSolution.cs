using UserPlugin._GenericServices;
using UserPlugin._GenericServices.Configuration;

namespace UserPlugin.Softec.Projects.ScanDeciever.Development;

[ManualTrigger("Open Solution", "Open ScanDeceiver Solution #sln")]
public class Sng_OpenSolution : SingletonService
{
	public override async Task ExecuteAsync()
	{
		var config = Resolve<Sng_Config_ScanDeceiver>();
		var rider = Resolve<Sng_OpenInRider>();
		await rider.OpenSolutionAsync(config.SolutionFilePath);
		
	}
}