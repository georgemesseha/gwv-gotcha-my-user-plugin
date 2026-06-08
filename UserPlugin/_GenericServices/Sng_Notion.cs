using System.Diagnostics;

namespace UserPlugin._GenericServices;

public class Sng_Notion : SingletonService
{
	
	private string _lastPageUrl = string.Empty;
	
	public async Task OpenAsync(string pageId, string handleTitle)
	{
		_lastPageUrl = $"notion://app.notion.com/{pageId}";
		// await DefaultBrowser.OpenAsync(url);
		Process.Start(new ProcessStartInfo
		{
			FileName = _lastPageUrl,
			UseShellExecute = true
		});
		var windowAgent = WindowManager.GetWindowAgent(handleTitle, WindowPicker, FallbackAction);
		await windowAgent.CaptureAsync();
	}

	private async Task OnRestore()
	{
		Process.Start(new ProcessStartInfo
		{
			FileName = _lastPageUrl,
			UseShellExecute = true
		}); 
		
		
		
		// Process.Start(new ProcessStartInfo
		// {
		// 	FileName = _lastPageUrl,
		// 	UseShellExecute = true
		// });
		// await GrabAppAsync(_lastHandleTitle, 
		//                    WindowPicker, 
		//                    FallbackAction,
		//                    OnRestore);
	}
	
	private bool WindowPicker(string title, uint processId)
	{
		var Process = System.Diagnostics.Process.GetProcessById((int)processId);
		return Process.ProcessName.ToLower() == "notion";
	}
	
	
	private async Task FallbackAction(bool windowAlreadyExists)
	{
		// await External.RunAndForgetAsync("notion");
		Process.Start(new ProcessStartInfo
		{
			FileName = _lastPageUrl,
			UseShellExecute = true
		});
	}

	
}