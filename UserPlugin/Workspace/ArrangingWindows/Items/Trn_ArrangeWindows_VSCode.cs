
namespace UserPlugin.Workspace.ArrangingWindows.Items;

[ManualTrigger("Arrange VSCode windows", 
               "Arranges VSCode's windows",
               false)]

public class Trn_ArrangeWindows_VSCode : TransientService
{
	public override async Task ExecuteAsync()
	{
		int count = await Context.Services.GlobalWindowManager.ArrangeWindowsOfProcessesAsync("code");
		if (count == 0)
		{
			_ = Context.Integration.RunAsFunctionAsync("code .", "C:\\", false, null, null);
			_ = Context.Dialog.SpeakAsync("Creating a new instance.");
		}
		Context.StatusMessage = $"Arranged {count} VSCode windows";
	}
}