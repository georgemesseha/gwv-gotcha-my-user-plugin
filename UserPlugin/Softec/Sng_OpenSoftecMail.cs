

using UserPlugin._GenericServices;

namespace UserPlugin.Softec;

public class Sng_OpenSoftecMail : SingletonService
{
	string tabSoftecMail => "Softec Mail";
	string urlSoftecMail => "https://outlook.office.com/mail/";
	
	public override async Task ExecuteAsync()
	{
		OpenSideViewForSoftecMail();
		await PauseAsync("Done?");
		
	}
	
	public void OpenSideViewForSoftecMail()
	{
		AddOrActivateWebPageTab(tabSoftecMail, urlSoftecMail);
	}
}