
using Gwv.Gotcha.Services;

namespace UserPlugin.Workspace.ArrangingWindows;

[ManualTrigger("k5p1i2c", "Rider", 
               "Arranges Rider's windows #tile 4444444444444444444444444444",
               false)]

public class Trn_ArrangeWindows_Rider : TransientService
{
	protected override async Task ExecuteAsync()
	{
		await ArrangeWindowsAsync();
	}
	
	public async Task ArrangeWindowsAsync()
	{
		bool isTargetWindow(IWindow window)
		{
			return new string[] { "rider64", "java" }.Any(name => window.Process.ProcessName.ToLower() == name);
		}
		var windows = await base.WindowManager.ArrangeWindowsAsync(isTargetWindow);
		
		// int count = await base.WindowManager.ArrangeWindowsOfAsync("rider64", "java");
		StatusMessage = $"Arranged {windows.Length} Notion windows";
	}
}