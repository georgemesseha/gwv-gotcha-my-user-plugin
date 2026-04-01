using UserPlugin._GenericServices.Configuration;
using UserPlugin.Softec.Projects.AgenticAI;

namespace UserPlugin.Root;


public class MyOption(string Title)
{
	public override string ToString()
	{
		return Title;
	}
}

[ManualTrigger("tttttttttttttTest", "Test")]
public class Sng_Test : SingletonService
{
	public override async Task ExecuteAsync()  
	{
		var result = await SelectAsync("Which one?",
		                               [
			                               new MyOption("Mine"),
			                               new MyOption("Yours")
		                               ]);

		_ = SpeakAsync("This is spoken from the service direct method");
		await WarnAsync($"You selected {result.selectedOption}");
		await InformAsync("This is a modeless message box from the service direct method");
		await PauseAsync("Press OK when ready");
		
		
		
		// if (result.isSkipped)
		// {
		// 	await WarnAsync("You skipped the answer");
		// }
		// else
		// {
			await PauseAsync($"You selected {result.selectedOption}");
		// }
		
		await ReportErrorAsync("This is an error from the service direct method");

		throw new Exception("This is a test exception");
		
		
		await Context.Dialog.RouteAsync("Routing question:", true,
		                                ("Agentic AI Project", typeof(Sng_AgenticAiProject)),
		                                ("Sahel", typeof(Sng_Config_Sahel)));
	}
}