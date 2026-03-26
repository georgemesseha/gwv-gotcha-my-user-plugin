using Gwv.Gotcha.Services.Plugin;

[ManualTrigger("💼 Projects", "Your currently active projects")]
public class Trn_Projects : TransientService
{
	
	public override async Task ExecuteAsync()
	{
		await Context.Dialog.RouteAsync("What project?", true,
		                                                    ("⚙️ All Projects Config", typeof(Sng_AllSoftecProjectsCommonFeatures)),
		                                                    ("💼 Sahel", typeof(Trn_SahelProject)),
		                                                    ("💼 Gotcha", typeof(Sng_GotchaProject)),
		                                                    ("💼 Auth", typeof(Sng_AuthProject)),
		                                                    ("💼 Agentic AI Project", typeof(Sng_AgenticAiProject))
		                                                    );
		
	}
}