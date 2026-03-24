[ManualTrigger("💼 Sahel", "Sahel Project")]
public class Trn_SahelProject : TransientService
{
	public override async Task ExecuteAsync()
	{
		var prjConfiguration = new McqOption("Configuration", "Configuration");
		var prjDevelopment = new McqOption("Development", "Development");
		var prjDeployment = new McqOption("Deployment", "Deployment");
		var prjRequirements = new McqOption("Requirements", "Requirements");
		
		var result = await Context.Dialog.AskMcqAsync("Which project are you working on?", 
		                                              new[] { prjConfiguration, prjDevelopment, prjDeployment, prjRequirements });
		
		if (result.isCancelled || Context.IsMarkedForTermination)
		{
			return;
		}
		
		switch (result.SelectedOption)
		{
			case { } when prjConfiguration == result.SelectedOption:
				await Context.Dialog.InfoAsync("Under construction");
				break;
			case {} when prjDevelopment == result.SelectedOption:
				var dev = Context.Resolve<Trn_SahelDevelopment>();
				// var dev = _serviceProvider.GetRequiredService<Trn_SahelDevelopment>();
				await dev.ExecuteAsync();

				break;
			case {} when prjDeployment == result.SelectedOption:
				await Context.Dialog.InfoAsync("Under construction");

				break;
			case {} when prjRequirements == result.SelectedOption:
				await Context.Dialog.InfoAsync("Under construction");

				break;
		}
	}
}