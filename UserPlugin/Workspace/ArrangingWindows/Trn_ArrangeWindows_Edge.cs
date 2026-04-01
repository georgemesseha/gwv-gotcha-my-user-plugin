
namespace UserPlugin.Workspace.ArrangingWindows.Items;

[ManualTrigger("Edge", 
               "Arranges Edge windows #tile",
               false)]
public class Trn_ArrangeWindows_Edge : TransientService
{
	public override async Task ExecuteAsync()
	{
		int count = await ArrangeWindowsOfAsync("msedge");
		if (count == 0)
		{
			_ = SpeakAsync("No Edge windows found");
		}
		StatusMessage = $"Arranged {count} Notion windows";
	}
}