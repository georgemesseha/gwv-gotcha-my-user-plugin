using UserPlugin._GenericServices;
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
		await Dialog.Add.InfoAsync("Hello World");
		
		await Dialog.Add.TextToSpeakAsync("Hello World");
		// await Dialog.AddCodeSnippetAsync("Hello World", "lorem ipsum dolor sit amet");

		await Dialog.PauseAsync("You're done");
		
		await RunExternalAsync("dir", "D:\\", stdOut =>
		                                      {
			                                      Dialog.Add.InfoAsync(stdOut); 
		                                      },
		                       stdErr =>
		                                      {
			                                      Dialog.Add.ErrorMessageAsync(stdErr);
		                                      });
		
		
		await Dialog.PauseAsync();
		
		var video = Resolve<Sng_VideoEditor>();
		await video.SplitVideoWhosePathOnClipboardAsync();
		
		var answer = await InputStringAsync("Please enter your name", input =>
		                                                              {
			                                                              if (string.IsNullOrWhiteSpace(input))
				                                                              return "Your name is required";
			                                                              else return string.Empty;
		                                                              });
		await Dialog.Add.InfoAsync($"Hello {answer}");
		await Dialog.PauseAsync();
		
		
		await Dialog.Add.WebPageAsync("Google", "Https://www.google.com");
		await Dialog.PauseAsync();
		
		
		
		
		await AddOrActivateWindowGrabberTabAsync("My Company Mail", IsOutlookPwaWindow, async @delegate =>
		                                                                     {
			                                                                     Console.Beep();
			                                                                     //await Dialog.Add.TextToSpeakAsync("Window not found from the plug-in");
		                                                                     });
		await Dialog.PauseAsync();
		await AddOrActivateWindowGrabberTabAsync("Vivaldi", IsVivaldi, @delegate => { });
		// await Dialog.PauseAsync();
		// return;
		
		
		
		await AddCodeSnippetAsync("Test code snippet", """
		                                               This is a test code snippet. It's a random text with no specific meaning. The purpose of this text is to test the code snippet feature of Gotcha. The text is written in a lorem ipsum style, with a mix of short and long sentences. The text is filled with words that are not part of the specific context of the test, but are common in the English language. The text is not grammatically correct, but it's not intended to be. The text is meant to be a random collection of words, without any specific meaning or structure. The text is not intended to be read or understood by anyone.
		                                               """);
		
		var result = await SelectAsync("Which one?",
		                               [
			                               new MyOption("Mine"), 
			                               new MyOption("Yours")
		                               ]);

		_ = Dialog.Add.TextToSpeakAsync("This is spoken from the service direct method");
		await Dialog.Add.WarningAsync($"You selected {result.selectedOption}");
		await Dialog.Add.InfoAsync("This is a modeless message box from the service direct method");
		await Dialog.PauseAsync("Press OK when ready");
		
		await AddOrActivateWindowGrabberTabAsync("My Company Mail", IsOutlookPwaWindow, @delegate =>
		                                                                     {
			                                                                     Console.Beep();
			                                                                     //Dialog.Add.TextToSpeakAsync("Window not found from the plugin");
		                                                                     });
		
		// if (result.isSkipped)
		// {
		// 	await WarnAsync("You skipped the answer");
		// }
		// else
		// {
			await Dialog.PauseAsync($"You selected {result.selectedOption}");
			
			await AddOrActivateWindowGrabberTabAsync("Vivaldi", IsVivaldi, null);
		// }
		await Dialog.PauseAsync($"You selected {result.selectedOption}");
		
		
		
		await AddOrActivateWindowGrabberTabAsync("My Company Mail", IsOutlookPwaWindow, @delegate =>
		                                                                     {
			                                                                     Dialog.Add.TextToSpeakAsync("Window not found from the plugin");
		                                                                     });
		
		// await ReportErrorAsync("This is an error from the service direct method");

		// throw new Exception("This is a test exception");

		await Dialog.PauseAsync();
		
		// await RouteAsync("Routing question:", true,
		//                                 ("Agentic AI Project", typeof(Sng_AgenticAiProject)),
		//                                 ("Sahel", typeof(Sng_Config_Sahel)));
	}

	private bool IsVivaldi(string title, uint processId)
	{
		return title.Contains("vivaldi", StringComparison.CurrentCultureIgnoreCase);
	}

	private bool IsOutlookPwaWindow(string title, uint processId)
	{
		return title.Contains("outlook", StringComparison.CurrentCultureIgnoreCase) 
		       && title.Contains("pwa", StringComparison.CurrentCultureIgnoreCase);
	}
}