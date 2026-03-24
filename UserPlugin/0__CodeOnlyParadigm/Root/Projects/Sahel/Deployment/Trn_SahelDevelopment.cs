
using Gwv.Gotcha.Services.Plugin;

public class Trn_SahelDeployment : TransientService
{
	public override async Task ExecuteAsync()
	{
		// var options = new McqOption[]
		// {
		// 	new McqOption("Open .sln", "Open backend solution file", Context.Resolve<Trn_Sahel_Rider_OpenSln>()),
		// 	new McqOption("Manage Git repo", "Manage Git repo", Context.Resolve<Trn_Sahel_ManageGitRepo>()),
		// };
		//
		// var result = await Context.Dialog.AskMcqAsync<IService>("Which project are you working on?", options);
		//
		// if (result.isCancelled || Context.IsMarkedForTermination)
		// {
		// 	return;
		// }
		//
		// await result.optionPayload!.ExecuteAsync();
		throw new NotImplementedException();
	}
}