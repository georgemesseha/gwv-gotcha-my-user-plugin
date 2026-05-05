
namespace UserPlugin.Workspace.ArrangingWindows;

[ManualTrigger("Terminal", 
               "Arranges Terminal windows #tile 111111111111111111111111111111",
               false)]
public class Trn_ArrangeWindows_Terminal : TransientService
{
	protected override async Task ExecuteAsync()
	{
		int count = await base.Integration.ArrangeWindowsOfAsync("WindowsTerminal", "cmd");
		if (count == 0)
		{
			_ = Dialog.Add.TextToSpeakAsync("No terminal windows found");
		}
		StatusMessage = $"Arranged {count} Notion windows";
	}
}