


namespace UserPlugin._GenericServices.Configuration;

public class Sng_Config_Sahel : SingletonService
{
	public string MainProjectPath => "D:\\Projects\\Sahel";
	public string ConfigurationProjectDir => "D:\\Projects\\__Sahel-Config__";
	
	
	public string BackendDirPath => Path.Join(MainProjectPath, "Backend");
	public string FrontendDirPath => Path.Join(MainProjectPath, "Frontend");
	public string SlnFilePath => Path.Join(BackendDirPath, "Sahel", "Sahel.sln");

	public string PullRequestsUrl => "https://dev.azure.com/SoftecMEA/Sahel/_git/Sahel/pullrequests?_a=mine";


	public override Task ExecuteAsync()
	{
		throw new NotImplementedException();
	}
}