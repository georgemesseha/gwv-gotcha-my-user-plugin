
namespace UserPlugin.Workspace.ArrangingWindows;

[ManualTrigger("o7n80q", "Vivaldi", 
               "Arranges Vivaldi's windows 9999999999999999999999999999",
               false)]

public class Trn_ArrangeWindows_Vivaldi : TransientService
{
	protected override async Task ExecuteAsync()
	{
		var windows = await base.WindowManager.ArrangeWindowsAsync(w => w.Process.ProcessName.ToLower() == "vivaldi");
		// int count = await base.WindowManager.ArrangeWindowsOfAsync("Vivaldi");
		if (windows.Length == 0)
		{
			_ = Dialog.Add.TextToSpeakAsync("Please open Vivaldi manually");
		}
		StatusMessage = $"Arranged {windows.Length} Notion windows";
	}
}