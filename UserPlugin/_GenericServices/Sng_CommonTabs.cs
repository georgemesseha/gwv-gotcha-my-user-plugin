
namespace UserPlugin._GenericServices;

public class Sng_CommonTabs : SingletonService
{
	public override Task ExecuteAsync()
	{
		throw new NotImplementedException();
	}
	
	public string Tab_SoftecAuthProjectMainPage => "Main Project Page";
	public string Url_SoftecAuthProjectMainPage => "https://www.notion.so/9d397c27567e4490a2d8b98cbe0f4640?v=b4be136bb3004fae8eee39279d619d40&source=copy_link";


	public string Tab_SafeCityPortal => "Safe City Portal";
	public string Url_SafeCityPortal =>"https://safecityportal.com/stream/?login=yes";
	
	
	public string Tab_SaaedDailyReport => "Daily Report";
	public string Url_SaaedDailyReport => "https://www.notion.so/Daily-Report-Form-3016ea6ef608801a8a16cb167299e695?source=copy_link";
	
	public string Tab_ChatGPT => "ChatGPT";
	public string Url_ChatGPT => "https://chat.openai.com/";
	
	public string Tab_VacationRequestInstructions => "Vacation Request Instructions";
	public string Url_VacationRequestInstructions => "https://www.notion.so/Softec-Send-vacation-request-email-1ba6ea6ef608800d9948c82b21e362f4?source=copy_link";
	
	
	
}