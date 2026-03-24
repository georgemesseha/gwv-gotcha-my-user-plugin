[ManualTrigger("💼 Sahel", "Sahel Project")]
public class Trn_SahelProject : TransientService
{
	public override async Task ExecuteAsync()
	{
		var options = new McqOption[]
		{
			new McqOption("Configuration", "Configuration", Context.Resolve<Trn_Sahel_ManageConfiguration>()),
			new McqOption("Development", "Development", Context.Resolve<Trn_SahelDevelopment>()),
			new McqOption("Deployment", "Deployment", Context.Resolve<Trn_SahelDeployment>()),
			new McqOption("Requirements", "Requirements", Context.Resolve<Trn_Sahel_Requirements>()),
		};

		var result = await Context.Dialog.AskMcqAsync<IService>("Which project are you working on?", options);
		
		if (result.isCancelled || Context.IsMarkedForTermination)
		{
			return;
		}
		
		await result.optionPayload!.ExecuteAsync();
	}
}