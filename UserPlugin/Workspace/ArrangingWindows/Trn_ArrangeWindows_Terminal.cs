
namespace UserPlugin.Workspace.ArrangingWindows;

[ManualTrigger("Terminal", 
               "Arranges Terminal windows #tile 111111111111111111111111111111",
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