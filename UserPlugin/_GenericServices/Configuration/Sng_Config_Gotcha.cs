


namespace UserPlugin._GenericServices.Configuration;

public class Sng_Config_Gotcha : SingletonService
{
	public string GotchaMainDirPath => "D:\\Projects\\gwv.Gotcha";
	public string GotchaSlnFilePath => Path.Join(GotchaMainDirPath, "Gwv.Gotcha.sln");
	
	
	public string PluginMainDirPath => "D:/Projects/__USER_PLUGIN__";
	public string PluginSlnFilePath => Path.Join(PluginMainDirPath, "__USER_PLUGIN__.sln");


	public override Task ExecuteAsync()
	{
		throw new NotImplementedException();
	}
}