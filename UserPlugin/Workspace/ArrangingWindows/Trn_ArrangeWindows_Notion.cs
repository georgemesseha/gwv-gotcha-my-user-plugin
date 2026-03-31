
namespace UserPlugin.Workspace.ArrangingWindows.Items;

[ManualTrigger("Notion", 
               "Brings Notion's window to the front #tile",
               false)]

public class Trn_ArrangeWindows_Notion : TransientService
{
	
	public override async Task ExecuteAsync()
	{
		int count = await Context.Services.GlobalWindowManager.ArrangeWindowsOfProcessesAsync("Notion");
		Context.StatusMessage = $"Arranged {count} Notion windows";
	}
}