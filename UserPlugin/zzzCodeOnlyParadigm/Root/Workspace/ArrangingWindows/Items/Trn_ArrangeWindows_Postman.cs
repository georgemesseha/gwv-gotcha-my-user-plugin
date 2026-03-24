
using Gwv.Gotcha.Services.Plugin;

[ManualTrigger("Show Postman", 
               "Brings Postman's window to the front #tile",
               false)]

public class Trn_ArrangeWindows_Postman : TransientService
{
	public override  async Task ExecuteAsync()
	{
		int count = await Context.Services.GlobalWindowManager.ArrangeWindowsOfProcessesAsync("Postman");
		if (count == 0)
		{
			_ = Context.Dialog.SpeakAsync("Please open postman manually");
		}
		Context.StatusMessage = $"Arranged {count} Notion windows";
	}
}