using Gwv.Gotcha.Services.Plugin;

[ManualTrigger("💼 Gotcha", "Gotcha Project")]
public class Trn_GotchaProject : TransientService
{
	public override async Task ExecuteAsync()
	{
		var options = new McqOption[]
		{
			new McqOption("Development", 
			              "Gotcha Development",  
			              Context.Resolve<Trn_GotchaDevelopment>()),
		};
		
		var result = await Context.Dialog.AskMcqAsync<IService>("Which one?", options);
		if(result.isCancelled)
		{
			return;
		}
		
		await result.optionPayload!.ExecuteAsync();
	}
}