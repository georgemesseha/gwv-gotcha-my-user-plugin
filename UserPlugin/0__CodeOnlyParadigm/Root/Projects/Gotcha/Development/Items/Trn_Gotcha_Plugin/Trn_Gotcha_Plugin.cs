
public class Trn_Gotcha_Plugin : TransientService
{
	public override async Task ExecuteAsync()
	{
		var options = new McqOption[]
		{
			new McqOption("Develop Plugin", 
			              "Develop Plugin", 
			              Context.Resolve<Trn_Gotcha_DevelopPlugin>()),
			new McqOption("Manage Git repo", 
			              "Manage Git repo", 
			              Context.Resolve<Trn_Gotcha_ManagePluginGitRepo>()),
		};
		
		var result = await Context.Dialog.AskMcqAsync<IService>("Which one?", options);
		if(result.isCancelled)
		{
			return;
		}
		
		await result.optionPayload!.ExecuteAsync();
	}
}