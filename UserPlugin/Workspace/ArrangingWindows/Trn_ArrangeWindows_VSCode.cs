
namespace UserPlugin.Workspace.ArrangingWindows.Items;

[ManualTrigger("VSCode", 
               "Arranges VSCode's windows 55555555555555555555555555555555",
               false)]

public class Trn_ArrangeWindows_VSCode : TransientService
{
	public override async Task ExecuteAsync()  
	{
		int count = await ArrangeWindowsOfAsync("code");
		if (count == 0)
		{
			_ = RunCommandAsFunctionAsync("code .", "C:\\", false, null, null);
			_ = SpeakAsync("Creating a new instance.");
		}
		StatusMessage = $"Arranged {count} VSCode windows";
	}
}