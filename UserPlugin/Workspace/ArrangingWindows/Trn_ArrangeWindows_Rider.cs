
namespace UserPlugin.Workspace.ArrangingWindows.Items;

[ManualTrigger("Rider", 
               "Arranges Rider's windows #tile",
               false)]

public class Trn_ArrangeWindows_Rider : TransientService
{
	public override async Task ExecuteAsync()
	{
		int count = await Context.Services.GlobalWindowManager.ArrangeWindowsOfProcessesAsync("rider64");
		Context.StatusMessage = $"Arranged {count} Notion windows";
	}
}