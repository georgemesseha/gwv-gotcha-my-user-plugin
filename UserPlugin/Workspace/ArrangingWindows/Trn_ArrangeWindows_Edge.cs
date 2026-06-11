
using Gwv.Gotcha.Services;

namespace UserPlugin.Workspace.ArrangingWindows;

[ManualTrigger("c0m8l7p", "Edge", 
               "Arranges Edge windows #tile 88888888888888888888888888888888888888",
               false)]
public class Trn_ArrangeWindows_Edge : TransientService
{
	protected override async Task ExecuteAsync()
	{
		await ArrangeWindowsAsync();
	}

	public async Task ArrangeWindowsAsync()
	{
		bool isTargetWindow(IWindow window)
		{
			return new string[] { "msedge" }.Any(name => window.Process.ProcessName.ToLower() == name);
		}
		var windows = await base.WindowManager.ArrangeWindowsAsync(isTargetWindow);
		
	}
}  