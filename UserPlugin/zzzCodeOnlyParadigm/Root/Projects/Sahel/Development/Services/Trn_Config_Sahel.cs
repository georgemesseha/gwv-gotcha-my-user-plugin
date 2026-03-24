


using Gwv.Gotcha.Services.Plugin;

public class Trn_Config_Sahel : SingletonService
{
	public string MainProjectPath => @"C:\Users\sahel\source\sahel\";
	public string BackendDirPath => Path.Join(MainProjectPath, "Backend");
	public string SlnFilePath => Path.Join(BackendDirPath, @"Sahel\Sahel.sln");


	public override Task ExecuteAsync()
	{
		throw new NotImplementedException();
	}
}