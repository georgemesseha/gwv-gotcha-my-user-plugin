
[ManualTrigger("Arrange windows ...", "Arrange/Tile windows of processes/apps")]
public class Trn_ArrangeWindows : TransientService
{
	public override async Task ExecuteAsync()
	{
		await Context.Dialog.RouteAsync("Which app to arrange its windows?", true,
		                                ("Vivaldi", typeof(Trn_ArrangeWindows_Vivaldi)),
		                                ("Vivaldi", typeof(Trn_ArrangeWindows_Vivaldi)),
		                                ("Edge", typeof(Trn_ArrangeWindows_Edge)),
		                                ("Terminal", typeof(Trn_ArrangeWindows_Terminal)),
		                                ("VSCode", typeof(Trn_ArrangeWindows_VSCode)),
		                                ("Teams", typeof(Trn_ArrangeWindows_Teams)),
		                                ("Rider", typeof(Trn_ArrangeWindows_Rider)),
		                                ("Postman", typeof(Trn_ArrangeWindows_Postman)),
		                                ("Notion", typeof(Trn_ArrangeWindows_Notion))
		                               );
		Context.Dismiss(); 
	}
}