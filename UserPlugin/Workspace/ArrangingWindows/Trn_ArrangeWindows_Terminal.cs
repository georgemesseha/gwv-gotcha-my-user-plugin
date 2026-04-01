
namespace UserPlugin.Workspace.ArrangingWindows.Items;

[ManualTrigger("Terminal", 
               "Arranges Terminal windows #tile",
               false)]
public class Trn_ArrangeWindows_Terminal : TransientService
{
	public override async Task ExecuteAsync()
	{
		int count = await ArrangeWindowsOfAsync("WindowsTerminal", "cmd");
		if (count == 0)
		{
			_ = SpeakAsync("No terminal windows found");
		}
		StatusMessage = $"Arranged {count} Notion windows";
	}
}