
namespace UserPlugin.Workspace.ArrangingWindows.Items;

[ManualTrigger("Terminal", 
               "Arranges Terminal windows #tile",
               false)]
public class Trn_ArrangeWindows_Terminal : TransientService
{
	public override async Task ExecuteAsync()
	{
		int count = await Context.Services.GlobalWindowManager.ArrangeWindowsOfProcessesAsync("WindowsTerminal", "cmd");
		if (count == 0)
		{
			_ = Context.Dialog.SpeakAsync("No terminal windows found");
		}
		Context.StatusMessage = $"Arranged {count} Notion windows";
	}
}