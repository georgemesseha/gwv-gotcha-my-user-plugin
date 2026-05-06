
namespace UserPlugin.Workspace.ArrangingWindows;

[ManualTrigger("Edge", 
               "Arranges Edge windows #tile 88888888888888888888888888888888888888",
               false)]
public class Trn_ArrangeWindows_Edge : TransientService
{
	protected override async Task ExecuteAsync()
	{
		int count = await base.WindowManager.ArrangeWindowsOfAsync("msedge");
		if (count == 0)
		{
			_ = Dialog.Add.TextToSpeakAsync("No Edge windows found");
		}
		StatusMessage = $"Arranged {count} Notion windows";
		
		
	}
}