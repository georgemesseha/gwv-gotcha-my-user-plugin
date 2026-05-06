
namespace UserPlugin.Workspace.ArrangingWindows;

[ManualTrigger("Teams", 
               "Arranges Teams windows #tile 222222222222222222",
               false)]

public class Trn_ArrangeWindows_Teams : TransientService
{
	protected override async Task ExecuteAsync()
	{
		int count = await base.WindowManager.ArrangeWindowsOfAsync( "ms-teams");
		if (count == 0)
		{
			_ = Dialog.Add.TextToSpeakAsync("Please open teams manually");
		}
		StatusMessage = $"Arranged {count} Notion windows";
	}
}