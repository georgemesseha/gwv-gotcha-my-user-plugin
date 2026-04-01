
namespace UserPlugin.Workspace.ArrangingWindows.Items;

[ManualTrigger("Rider", 
               "Arranges Rider's windows #tile",
               false)]

public class Trn_ArrangeWindows_Rider : TransientService
{
	public override async Task ExecuteAsync()
	{
		int count = await ArrangeWindowsOfAsync("rider64", "java");
		StatusMessage = $"Arranged {count} Notion windows";
	}
}