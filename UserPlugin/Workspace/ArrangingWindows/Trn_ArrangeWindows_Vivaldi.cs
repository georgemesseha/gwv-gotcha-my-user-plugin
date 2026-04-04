
namespace UserPlugin.Workspace.ArrangingWindows.Items;

[ManualTrigger("Vivaldi", 
               "Arranges Vivaldi's windows 9999999999999999999999999999",
               false)]

public class Trn_ArrangeWindows_Vivaldi : TransientService
{
	public override async Task ExecuteAsync()
	{
		int count = await ArrangeWindowsOfAsync("Vivaldi");
		if (count == 0)
		{
			_ = SpeakAsync("Please open Vivaldi manually");
		}
		StatusMessage = $"Arranged {count} Notion windows";
	}
}