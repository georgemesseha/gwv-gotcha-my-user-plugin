using UserPlugin._GenericServices;
using UserPlugin._GenericServices.Configuration;

namespace UserPlugin.Softec.Projects.Sahel.Development;

[ManualTrigger("t55p0f", "Manage Git repo", 
               "Manage Sahel Git repo",
               false )] 
  
public class Trn_Sahel_ManageGitRepo : TransientService
{
	protected override async Task ExecuteAsync()
	{
		var config = Resolve<Sng_Config_Sahel>();
		var openInVsCode = Resolve<Sng_OpenInVsCode>();
		await openInVsCode.OpenDirectoryAsync(config.MainProjectPath);
	}
}