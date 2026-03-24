

using Gwv.Gotcha.Services.Plugin;

[ManualTrigger("Open Sahel sln in  Rider", "Open Sahel backend solution in Rider")]

public class Trn_Sahel_Rider_OpenSln : TransientService
{
	private readonly Trn_Config_Sahel _trnConfigSahel;

	public Trn_Sahel_Rider_OpenSln(Trn_Config_Sahel trnConfigSahel)
	{
		_trnConfigSahel = trnConfigSahel;
	}
	
	public override async Task ExecuteAsync()
	{
		_ = Context.Integration.RunAsFunctionAsync($"rider {_trnConfigSahel.SlnFilePath}",
		                                       _trnConfigSahel.BackendDirPath,
		                                       false,
		                                       null,
		                                       null
		                                      );
	}
}