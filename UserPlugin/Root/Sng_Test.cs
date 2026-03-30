using UserPlugin._GenericServices.Configuration;
using UserPlugin.Softec.Projects.AgenticAI;

namespace UserPlugin.Root;

[ManualTrigger("tttttttttttttTest", "Test")]
public class Sng_Test : SingletonService
{
	public override async Task ExecuteAsync()  
	{
		var result = await Context.Dialog.SelectStringValueAsync("Which one?", new[] { "Mine", "Yours" }, true);

		if (result.isSkipped)
		{
			await Context.Dialog.WarningAsync("You skipped the answer");
		}
		else
		{
			await Context.Dialog.InfoAsync($"You selected {result.value}");
		}
		
		
		await Context.Dialog.RouteAsync("Routing question:", true,
		                                ("Agentic AI Project", typeof(Sng_AgenticAiProject)),
		                                ("Sahel", typeof(Sng_Config_Sahel)));
	}
}