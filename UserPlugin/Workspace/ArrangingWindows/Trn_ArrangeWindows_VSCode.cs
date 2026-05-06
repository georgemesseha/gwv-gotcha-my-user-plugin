
namespace UserPlugin.Workspace.ArrangingWindows;

[ManualTrigger("VSCode", 
               "Arranges VSCode's windows 55555555555555555555555555555555 tile",
               true)]

public class Trn_ArrangeWindows_VSCode : TransientService
{
	protected override async Task ExecuteAsync()  
	{
		var windows = await base.WindowManager.ArrangeWindowsAsync(w => w.Process.ProcessName.ToLower() == "code");
		
		
		// int count = await base.WindowManager.ArrangeWindowsOfAsync("code");
		if (windows.Length == 0)
		{
			_ = Run.Command.NonInteractiveAsync("code .", "C:\\", null, null);
			_ = Dialog.Add.TextToSpeakAsync("Creating a new instance.");
		}
		StatusMessage = $"Arranged {windows.Length} VSCode windows";
	}
}