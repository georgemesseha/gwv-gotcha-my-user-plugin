
namespace UserPlugin.Workspace.ArrangingWindows;

[ManualTrigger("Postman", 
               "Brings Postman's window to the front #tile 66666666666666666666666",
               false)]

public class Trn_ArrangeWindows_Postman : TransientService
{
	public override  async Task ExecuteAsync()
	{
		int count = await base.Integration.ArrangeWindowsOfAsync("Postman");
		if (count == 0)
		{
			_ = Dialog.Add.TextToSpeakAsync("Please open postman manually");
		}
		StatusMessage = $"Arranged {count} Notion windows";
	}
}