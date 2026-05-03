
namespace UserPlugin.Workspace.ArrangingWindows;

[ManualTrigger("VSCode", 
               "Arranges VSCode's windows 55555555555555555555555555555555 tile",
               true)]

public class Trn_ArrangeWindows_VSCode : TransientService
{
	public override async Task ExecuteAsync()  
	{
		int count = await base.Integration.ArrangeWindowsOfAsync("code");
		if (count == 0)
		{
			_ = Integration.RunProcessAsync("code .", "C:\\", null, null);
			_ = Dialog.Add.TextToSpeakAsync("Creating a new instance.");
		}
		StatusMessage = $"Arranged {count} VSCode windows";
	}
}