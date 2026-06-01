


namespace UserPlugin._GenericServices.Configuration;

public class Sng_Config_SoftecAuth : SingletonService
{
	public string RepoDirPath => "D:\\Projects\\Saaed.AuthService\\SaaedAuth";
	public string SolutionDirePath => Path.Join(RepoDirPath, "Saaed.AuthService");
	public string SlnFilePath => Path.Join(SolutionDirePath, "Softec.Auth.sln");
	
}