
namespace UserPlugin.Workspace.ArrangingWindows;

[ManualTrigger("Rider", 
               "Arranges Rider's windows #tile 4444444444444444444444444444",
               false)]

public class Trn_ArrangeWindows_Rider : TransientService
{
	public override async Task ExecuteAsync()
	{
		int count = await ArrangeWindowsOfAsync("rider64", "java");
		StatusMessage = $"Arranged {count} Notion windows";
	}
}