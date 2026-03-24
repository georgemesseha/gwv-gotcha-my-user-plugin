
using Gwv.Gotcha.Services.Plugin;

[ManualTrigger("Arrange Vivaldi windows", 
               "Arranges Vivaldi's windows",
               false)]

public class ArrangeWindows_Vivaldi : TransientService
{
	public override async Task ExecuteAsync()
	{
		int count = await Context.Services.GlobalWindowManager.ArrangeWindowsOfProcessesAsync("Vivaldi");
		if (count == 0)
		{
			_ = Context.Dialog.SpeakAsync("Please open Vivaldi manually");
		}
		Context.StatusMessage = $"Arranged {count} Notion windows";
	}
}