using System.Diagnostics;

namespace UserPlugin._GenericServices;

public class Sng_Notion : SingletonService
{
	
	private string _lastPageUrl = string.Empty;
	private string _lastHandleTitle = string.Empty;
	
	public async Task GrabNotion(string pageId, string handleTitle)
	{
		_lastPageUrl = $"notion://app.notion.com/{pageId}";
		// await DefaultBrowser.OpenAsync(url);
		Process.Start(new ProcessStartInfo
		{
			FileName = _lastPageUrl,
			UseShellExecute = true
		});
		await CaptureWindowAsync(handleTitle, 
		                   WindowPicker, 
		                   FallbackAction,
		                   OnRestore);
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
	
	
	private async Task FallbackAction()
	{
		// await External.RunAndForgetAsync("notion");
		Process.Start(new ProcessStartInfo
		{
			FileName = _lastPageUrl,
			UseShellExecute = true
		});
	}

	
}