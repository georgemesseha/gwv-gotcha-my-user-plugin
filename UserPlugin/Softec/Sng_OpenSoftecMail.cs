

using System.Diagnostics;
using Gwv.Gotcha.Services.Contracts;
using UserPlugin._GenericServices;

namespace UserPlugin.Softec;

[ManualTrigger("i2h6g7g7m8j0p6")]
public class Sng_OpenSoftecMail : SingletonService
{
	// string tabSoftecMail => "Softec Mail";
	// string urlSoftecMail => "https://outlook.office.com/mail/";
	
	protected override async Task ExecuteAsync()
	{


		await OpenSoftecMailPwaAsync();
		await PauseAsync("Done?");
		
	}
	
	
	// public async Task OpenSideViewForSoftecMailAsync()
	// {
	// 	await Dialog.Add.WebPageAsync(tabSoftecMail, urlSoftecMail);
	// }
	
	public async Task OpenSoftecMailPwaAsync()
	{
		var windowAgent = GetWindowAgent("Softec Mail", IsSoftecMailPwa, OnEnsureWindow);
		await windowAgent.CaptureAsync();
		// await CaptureWindowAsync("Softec Mail", IsSoftecMailPwa, FallbackAction);
	}
	
	private async Task OnEnsureWindow(bool windowAlreadyExists)
	{
		if (windowAlreadyExists) return;
		Process.Start(new ProcessStartInfo
		{
			FileName = "msedge",
			Arguments = "--profile-directory=Default --app=https://outlook.office.com/mail/",
			UseShellExecute = true
		});
	}

	private bool IsSoftecMailPwa(string title, uint processId)
	{
		return (title.Contains("Outlook", StringComparison.CurrentCultureIgnoreCase) &&
		    title.Contains("Mail", StringComparison.CurrentCultureIgnoreCase)) ;
	}
	
	
}