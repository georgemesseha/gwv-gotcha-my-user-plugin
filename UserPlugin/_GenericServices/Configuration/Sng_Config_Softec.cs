
namespace UserPlugin._GenericServices.Configuration;

public class Sng_Config_Softec : SingletonService
{
	public override Task ExecuteAsync()
	{
		throw new NotImplementedException();
	}
	
	public string PortalUrl => "https://safecityportal.com/stream/?login=yes";
	
}