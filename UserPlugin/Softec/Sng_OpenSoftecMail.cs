

using System.Diagnostics;
using UserPlugin._GenericServices;

namespace UserPlugin.Softec;

public class Sng_OpenSoftecMail : SingletonService
{
	string tabSoftecMail => "Softec Mail";
	string urlSoftecMail => "https://outlook.office.com/mail/";
	
	public override async Task ExecuteAsync()
	{
		await OpenSideViewForSoftecMailAsync();
		await PauseAsync("Done?");
		
	}
	
	public async Task OpenSideViewForSoftecMailAsync()
	{
		await AddOrActivateWebPageTabAsync(tabSoftecMail, urlSoftecMail);
	}
	
	public async Task OpenSoftecMailPwaAsync()
	{
		// await AddOrActivateWebPageTabAsync(tabSoftecMail, urlSoftecMail);
		
		// var process = Process.Start(new ProcessStartInfo
		// {
		// 	FileName = "msedge.exe",
		// 	Arguments = "--app=https://outlook.office.com/mail/",
		// 	UseShellExecute = true
		// });
		// process?.WaitForInputIdle();
		await AddOrActivateWindowGrabberTabAsync("Softec Mail", IsSoftecMailPwa, null);
	}

	private bool IsSoftecMailPwa(string title, uint processId)
	{
		return (title.Contains("Outlook", StringComparison.CurrentCultureIgnoreCase) &&
		    title.Contains("pwa", StringComparison.CurrentCultureIgnoreCase)) ;
	}
}