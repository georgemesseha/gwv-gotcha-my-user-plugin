
using UserPlugin.Workspace.ArrangingWindows;

namespace UserPlugin.Workspace;

[ManualTrigger("Workspace", 
               "Contains everyday tasks of managing the workspace.")]
public class Trn_Workspace : TransientService
{
	public override async Task ExecuteAsync()
	{
		await Context.Dialog.RouteAsync("Pick a workspace action?", true,
		                                ("Arrange windows", typeof(Trn_ArrangeWindows))
		                               );
	}
}