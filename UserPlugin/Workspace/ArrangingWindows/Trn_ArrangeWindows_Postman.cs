
namespace UserPlugin.Workspace.ArrangingWindows.Items;

[ManualTrigger("Postman", 
               "Brings Postman's window to the front #tile 66666666666666666666666",
               false)]

public class Trn_ArrangeWindows_Postman : TransientService
{
	public override  async Task ExecuteAsync()
	{
		int count = await ArrangeWindowsOfAsync("Postman");
		if (count == 0)
		{
			_ = SpeakAsync("Please open postman manually");
		}
		StatusMessage = $"Arranged {count} Notion windows";
	}
}