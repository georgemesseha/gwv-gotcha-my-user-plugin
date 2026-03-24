using Gwv.Gotcha.Services.Plugin;

[ManualTrigger("Projects", "Your currently active projects")]
public class Trn_Projects : TransientService
{
	
	public override async Task ExecuteAsync()
	{
		var prjSahel = new McqOption("Sahel", "Sahel");
		var prjGotcha = new McqOption("Gotcha", "Gotcha");
		var prjSoftecAuth = new McqOption("Softec Auth", "Softec Auth");
		
		var result = await Context.Dialog.AskMcqAsync("Which project are you working on?", 
		                                              new[] { prjSahel, prjGotcha, prjSoftecAuth });

		if (result.isCancelled || Context.IsMarkedForTermination)
		{
			return;
		}

		switch (result.SelectedOption)
		{
			case { } when prjSahel == result.SelectedOption:
				var sahelPrj = Context.Resolve<Trn_SahelProject>();
				// var sahelPrj = _serviceProvider.GetRequiredService<Trn_SahelProject>();
				await sahelPrj.ExecuteAsync();
				break;
			case {} when prjGotcha == result.SelectedOption:
				var gotchaPrj = Context.Resolve<Trn_GotchaProject>();
				await gotchaPrj.ExecuteAsync();
				break;
			case {} when prjSoftecAuth == result.SelectedOption:
				var authPrj = Context.Resolve<Trn_AuthProject>();
				await authPrj.ExecuteAsync();
				break;
		}
		
		

	}
}