
namespace UserPlugin.Workspace.ArrangingWindows;

[ManualTrigger("Vivaldi", 
               "Arranges Vivaldi's windows 9999999999999999999999999999",
               false)]

public class Trn_ArrangeWindows_Vivaldi : TransientService
{
	protected override async Task ExecuteAsync()
	{
		int count = await base.WindowManager.ArrangeWindowsOfAsync("Vivaldi");
		if (count == 0)
		{
			_ = Dialog.Add.TextToSpeakAsync("Please open Vivaldi manually");
		}
		StatusMessage = $"Arranged {count} Notion windows";
	}
}