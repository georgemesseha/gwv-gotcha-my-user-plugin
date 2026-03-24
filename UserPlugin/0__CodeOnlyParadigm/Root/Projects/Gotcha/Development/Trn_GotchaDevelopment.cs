
public class Trn_GotchaDevelopment : TransientService
{
	public override async Task ExecuteAsync()
	{
		var options = new McqOption[]
		{
			new McqOption("Solution", 
			              "Develop Solution", 
			              Context.Resolve<Trn_Gotcha_Solution>()),
			new McqOption("Plugin", 
			              "Develop Plugin", 
			              Context.Resolve<Trn_Gotcha_Plugin>()),
		};
		
		var result = await Context.Dialog.AskMcqAsync<IService>("Which one?", options);
		if(result.isCancelled)
		{
			return;
		}
		
		await result.optionPayload!.ExecuteAsync();
	}
}