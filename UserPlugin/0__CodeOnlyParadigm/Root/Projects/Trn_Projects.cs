using Gwv.Gotcha.Services.Plugin;

[ManualTrigger("Projects", "Your currently active projects")]
public class Trn_Projects : TransientService
{
	
	public override async Task ExecuteAsync()
	{
		var options = new[]
		{
			new McqOption("Sahel", 
			              "Sahel", 
			              Context.Resolve<Trn_SahelProject>()),
			new McqOption("Gotcha", 
			              "Gotcha", 
			              Context.Resolve<Trn_GotchaProject>()),
			new McqOption("Auth", 
			              "Auth", 
			              Context.Resolve<Trn_AuthProject>()),
		};

		var result = await Context.Dialog.AskMcqAsync<IService>("Which one?", options);

		if (result.isCancelled || Context.IsMarkedForTermination)
		{
			return;
		}
		
		await result.optionPayload!.ExecuteAsync();
	}
}