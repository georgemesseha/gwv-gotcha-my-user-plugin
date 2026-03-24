
public class Trn_Gotcha_Solution : TransientService
{
	public override async Task ExecuteAsync()
	{
		var options = new McqOption[]
		{
			new McqOption("Open Solution", 
			              "Develop Solution", 
			              Context.Resolve<Trn_Gotcha_DevelopSolution>()),
			new McqOption("Manage Git repo", 
			              "Manage Git repo", 
			              Context.Resolve<Trn_Gotcha_ManageSolutionGitRepo>()),
		};
		
		var result = await Context.Dialog.AskMcqAsync<IService>("Which one?", options);
		if(result.isCancelled)
		{
			return;
		}
		
		await result.optionPayload!.ExecuteAsync();
	}
}