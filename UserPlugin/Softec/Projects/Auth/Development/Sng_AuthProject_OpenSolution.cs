using UserPlugin._GenericServices;
using UserPlugin._GenericServices.Configuration;

namespace UserPlugin.Softec.Projects.Auth.Development.Items;

public class Sng_AuthProject_OpenSolution : SingletonService
{
	public override async Task ExecuteAsync()
	{
		var sngConfig = Context.Resolve<Sng_Config_SoftecAuth>();
		var sngOpenInRider = Context.Resolve<Sng_OpenInRider>();
		await sngOpenInRider.OpenSolutionAsync(sngConfig.SlnFilePath);
	}
}