
using Gwv.Gotcha.Services.Plugin;

[ManualTrigger("Arrange Edge windows", 
               "Arranges Edge windows #tile",
               false)]
public class ArrangeWindows_Edge : TransientService
{
	public override async Task ExecuteAsync()
	{
		int count = await Context.Services.GlobalWindowManager.ArrangeWindowsOfProcessesAsync("msedge");
		if (count == 0)
		{
			_ = Context.Dialog.SpeakAsync("No Edge windows found");
		}
		Context.StatusMessage = $"Arranged {count} Notion windows";
	}
}