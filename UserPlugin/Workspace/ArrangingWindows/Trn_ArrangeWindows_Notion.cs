
namespace UserPlugin.Workspace.ArrangingWindows;

[ManualTrigger("Notion", 
               "Brings Notion's window to the front #tile 0000000000000000000000000000000000000000",
               false)]

public class Trn_ArrangeWindows_Notion : TransientService
{
	
	public override async Task ExecuteAsync()
	{
		int count = await ArrangeWindowsOfAsync("Notion");
		StatusMessage = $"Arranged {count} Notion windows";
	}
}