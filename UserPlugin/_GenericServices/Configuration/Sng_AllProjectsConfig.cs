namespace UserPlugin._GenericServices.Configuration;

public class Sng_AllProjectsConfig : SingletonService
{
	public override Task ExecuteAsync()
	{
		throw new NotImplementedException();
	}
	
	public string LocalConfigDir => @"D:\ProjectsConfig";
}