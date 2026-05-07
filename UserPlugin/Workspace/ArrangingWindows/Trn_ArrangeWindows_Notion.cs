
namespace UserPlugin.Workspace.ArrangingWindows;

[ManualTrigger("v5b3u6s", "Notion", 
               "Brings Notion's window to the front #tile 0000000000000000000000000000000000000000",
               false)]

public class Trn_ArrangeWindows_Notion : TransientService
{
	
	protected override async Task ExecuteAsync()
	{
		var windows = await base.WindowManager.ArrangeWindowsAsync(w => w.Process.ProcessName.ToLower() == "notion");
		StatusMessage = $"Arranged {windows.Length} Notion windows";
	}
}