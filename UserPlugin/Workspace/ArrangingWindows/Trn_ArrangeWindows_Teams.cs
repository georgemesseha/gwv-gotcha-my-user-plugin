
namespace UserPlugin.Workspace.ArrangingWindows.Items;

[ManualTrigger("Teams", 
               "Arranges Teams windows #tile",
               false)]

public class Trn_ArrangeWindows_Teams : TransientService
{
	public override async Task ExecuteAsync()
	{
		int count = await ArrangeWindowsOfAsync( "ms-teams");
		if (count == 0)
		{
			_ = SpeakAsync("Please open teams manually");
		}
		StatusMessage = $"Arranged {count} Notion windows";
	}
}