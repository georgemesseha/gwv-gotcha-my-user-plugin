


namespace UserPlugin._GenericServices.Configuration;

public class Sng_Config_SoftecAuth : SingletonService
{
	public string MainProjectPath => "D:\\Projects\\Saaed.AuthService\\SaaedAuth";
	public string SolutionFolder => "Saaed.AuthService";
	public string SlnFilePath => Path.Join(MainProjectPath, SolutionFolder, "Softec.Auth.sln");
	


	public override Task ExecuteAsync()
	{
		throw new NotImplementedException();
	}
}