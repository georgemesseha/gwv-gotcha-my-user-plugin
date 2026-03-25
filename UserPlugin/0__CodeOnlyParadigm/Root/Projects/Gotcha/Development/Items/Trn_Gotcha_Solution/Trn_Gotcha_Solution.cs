
public class Trn_Gotcha_Solution : TransientService
{
	public override async Task ExecuteAsync()
	{
		var service = await Context.Dialog.PickServiceAsync("Action?",
		                                              ("Develop Gotcha", typeof(Trn_Gotcha_DevelopSolution)),
		                                              ("Manage Git repo", typeof(Trn_Gotcha_ManageSolutionGitRepo)),
		                                              ("Exit", typeof(Trn_Exit))
			                                                    );

		await service.ExecuteAsync();
	}
}