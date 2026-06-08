
namespace UserPlugin.Workspace.ArrangingWindows;

[ManualTrigger("k9w0a8", "Teams", 
               "Arranges Teams windows #tile 222222222222222222",
               false)]

public class Trn_ArrangeWindows_Teams : TransientService
{
	protected override async Task ExecuteAsync()
	{
		await ArrangeWindowsAsync();
		
	}
	
	public async Task ArrangeWindowsAsync()
	{
		var windows = await base.WindowManager.ArrangeWindowsAsync(w => w.Process.ProcessName == "ms-teams"
		                                                                && w.ClassName == "TeamsWebView");
		
		// int count = await base.WindowManager.ArrangeWindowsOfAsync( "ms-teams");
		if (windows.Length == 0)
		{
			_ = Dialog.Add.TextToSpeakAsync("Launching teams toooooot"); 
			await External.RunAndForgetAsync("ms-teams");
			// _ = Dialog.Add.TextToSpeakAsync("Please open teams manually");
		}
		
		StatusMessage = $"Arranged {windows.Length} Notion windows";
	}
}