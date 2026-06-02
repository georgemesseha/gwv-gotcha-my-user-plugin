
using Gwv.Gotcha.Services;

namespace UserPlugin.Workspace.ArrangingWindows;

[ManualTrigger("v9k3a4k", "Terminal", 
               "Arranges Terminal windows #tile 111111111111111111111111111111",
               false)]
public class Trn_ArrangeWindows_Terminal : TransientService
{
	protected override async Task ExecuteAsync()
	{
		bool isTargetWindow(IWindow window)
		{
			return new string[] { "windowsterminal", "cmd", "pwsh", "powershell" }.Any(name => window.Process.ProcessName.ToLower() == name);
		}
		var windows = await base.WindowManager.ArrangeWindowsAsync(isTargetWindow);
		
		// int count = await base.WindowManager.ArrangeWindowsOfAsync("WindowsTerminal", "cmd");
		if (windows.Length == 0)
		{
			_ = Dialog.Add.TextToSpeakAsync("No terminal windows found");
		}
		StatusMessage = $"Arranged {windows.Length} Notion windows";
	}
}