
namespace UserPlugin.Workspace.ArrangingWindows.Items;

[ManualTrigger("Arrange Teams windows", 
               "Arranges Teams windows #tile",
               false)]

public class Trn_ArrangeWindows_Teams : TransientService
{
	public override async Task ExecuteAsync()
	{
		int count = await Context.Services.GlobalWindowManager.ArrangeWindowsOfProcessesAsync( "ms-teams");
		if (count == 0)
		{
			_ = Context.Dialog.SpeakAsync("Please open teams manually");
		}
		Context.StatusMessage = $"Arranged {count} Notion windows";
	}
}