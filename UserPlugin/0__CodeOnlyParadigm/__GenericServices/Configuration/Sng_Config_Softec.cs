
public class Sng_Config_Softec : SingletonService
{
	public override Task ExecuteAsync()
	{
		throw new NotImplementedException();
	}
	
	public string PortalUrl => "https://safecityportal.com/stream/?login=yes";
	public string DailyReportUrl => "https://www.notion.so/Daily-Report-Form-3016ea6ef608801a8a16cb167299e695?source=copy_link";
}