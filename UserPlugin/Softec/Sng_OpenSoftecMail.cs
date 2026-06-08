

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
		await Edge.OpenAsync("https://mail.google.com/mail/u/2/#inbox", "Gmail", "inbox");
		await Dialog.Add.InfoAsync("Login by g.saeed@safecity.com");
		await PauseAsync("Done?");
	}
	
	
	public async Task OpenSoftecMailPwaAsync()
	{
		var windowAgent = WindowManager.GetWindowAgent("Softec Mail", IsSoftecMailPwa, OnEnsureWindow);
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