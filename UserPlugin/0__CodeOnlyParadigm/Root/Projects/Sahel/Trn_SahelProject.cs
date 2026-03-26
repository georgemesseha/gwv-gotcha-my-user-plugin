[ManualTrigger("💼 Sahel", "Sahel Project")]
public class Trn_SahelProject : TransientService
{
	public override async Task ExecuteAsync()
	{
		await Context.Dialog.RouteAsync("Pick a project wide action category:", true,
		                                ("Configuration", typeof(Sng_AllProjects_ManageConfiguration)),
		                                  ("Development", typeof(Trn_SahelDevelopment)),
		                                  ("Deployment", typeof(Trn_SahelDeployment)),
		                                  ("Requirements", typeof(Trn_Sahel_Requirements))
		                                 );
	}
}