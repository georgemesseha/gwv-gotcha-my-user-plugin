
using Gwv.Gotcha.Services.Plugin;

[ManualTrigger("Show Notion", 
               "Brings Notion's window to the front #tile",
               false)]

public class ArrangeWindows_Notion : TransientService
{
	
	public override async Task ExecuteAsync()
	{
		int count = await Context.Services.GlobalWindowManager.ArrangeWindowsOfProcessesAsync("Notion");
		Context.StatusMessage = $"Arranged {count} Notion windows";
	}
}