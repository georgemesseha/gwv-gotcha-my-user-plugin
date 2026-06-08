using System.Diagnostics;

namespace UserPlugin._GenericServices;

public class Sng_SafeCity : SingletonService
{
	public async Task OpenPortalPwaAsync()
	{
		var windowAgent = WindowManager.GetWindowAgent("Safe City Portal", WindowPicker, OnEnsureWindow);
		await windowAgent.CaptureAsync();
	}
	
	private async Task OnEnsureWindow(bool windowAlreadyExists)
	{
		if (windowAlreadyExists) return;
		Process.Start(new ProcessStartInfo
		{
			FileName = "msedge",
			Arguments = "--profile-directory=Default --app=https://safe.city/daily-reports",
			UseShellExecute = true
		});
	}
	


	private bool WindowPicker(string title, uint processId)
	{
		title = title.ToLower();
		return (
			       (
				       // (title.Contains("safe") && title.Contains("city")) || 
				       title.Contains("scg")
				       ) && title.Contains("portal")
			       );
	}
}