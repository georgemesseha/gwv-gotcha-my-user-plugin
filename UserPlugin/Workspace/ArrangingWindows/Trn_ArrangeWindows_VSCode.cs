
namespace UserPlugin.Workspace.ArrangingWindows;

[ManualTrigger("VSCode", 
               "Arranges VSCode's windows 55555555555555555555555555555555 tile",
               false)]

public class Trn_ArrangeWindows_VSCode : TransientService
{
	public override async Task ExecuteAsync()  
	{
		int count = await ArrangeWindowsOfAsync("code");
		if (count == 0)
		{
			_ = RunExternalAsync("code .", "C:\\", false, null, null);
			_ = Dialog.Add.TextToSpeakAsync("Creating a new instance.");
		}
		StatusMessage = $"Arranged {count} VSCode windows";
	}
}