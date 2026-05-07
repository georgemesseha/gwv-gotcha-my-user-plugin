
namespace UserPlugin.Workspace.ArrangingWindows;

[ManualTrigger("v6r3t1l", "Postman", 
               "Brings Postman's window to the front #tile 66666666666666666666666",
               false)]

public class Trn_ArrangeWindows_Postman : TransientService
{ 
	protected override  async Task ExecuteAsync()
	{
		var windows = await base.WindowManager.ArrangeWindowsAsync(w => w.Process.ProcessName.ToLower() == "postman");
		// int count = await base.WindowManager.ArrangeWindowsOfAsync("Postman");
		if (windows.Length == 0)
		{
			_ = Dialog.Add.TextToSpeakAsync("Please open postman manually");
		}
		StatusMessage = $"Arranged {windows.Length} Notion windows";
	}
}