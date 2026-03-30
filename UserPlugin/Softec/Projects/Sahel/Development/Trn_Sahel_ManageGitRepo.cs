using UserPlugin._GenericServices;
using UserPlugin._GenericServices.Configuration;

namespace UserPlugin.Softec.Projects.Sahel.Development;

[ManualTrigger("Manage Sahel Git repo", 
               "Manage Sahel Git repo",
               false )]

public class Trn_Sahel_ManageGitRepo : TransientService
{
	public override async Task ExecuteAsync()
	{
		var config = Context.Resolve<Sng_Config_Sahel>();
		var openInVsCode = Context.Resolve<Sng_OpenInVsCode>();
		await openInVsCode.OpenDirectory(config.MainProjectPath);
	}
}