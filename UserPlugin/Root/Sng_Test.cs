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
		await AddCodeSnippetAsync("Test code snippet", """
		                                               This is a test code snippet. It's a random text with no specific meaning. The purpose of this text is to test the code snippet feature of Gotcha. The text is written in a lorem ipsum style, with a mix of short and long sentences. The text is filled with words that are not part of the specific context of the test, but are common in the English language. The text is not grammatically correct, but it's not intended to be. The text is meant to be a random collection of words, without any specific meaning or structure. The text is not intended to be read or understood by anyone.
		                                               """);
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
		
		
		await RouteAsync("Routing question:", true,
		                                ("Agentic AI Project", typeof(Sng_AgenticAiProject)),
		                                ("Sahel", typeof(Sng_Config_Sahel)));
	}
}