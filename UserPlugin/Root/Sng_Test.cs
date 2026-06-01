using System.Diagnostics;
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

[ManualTrigger("k6v3l2o", "tttttttttttttTest", "Test")]
public class Sng_Test : SingletonService
{
	protected override async Task ExecuteAsync()
	{
		DateTime dueTime = DateTime.Now.AddSeconds(10);

		await GrabAppAsync("Postman", WindowPicker, FallbackAction);

		async Task FallbackAction()
		{
			await External.RunAndForgetAsync("postman", ".");
		}

		bool WindowPicker(string title, uint processId)
		{
			var process = Process.GetProcessById((int)processId);
			return (process.ProcessName.ToLower() == "postman") ;
		}

		await External.RunAndForgetAsync("koala", ".");


		await PauseAsync();
		async Task<(bool success, string statusMessage)> SuccessChecker()
		{
			var success = (dueTime - DateTime.Now) <= TimeSpan.FromSeconds(5);
			if (success) return (true, "Eventually found it!");
			// return false;
			return (false, "Still waiting!");
		}

		await WaitUntilAsync("Waiting for the Lens window to show up", 
		                     SuccessChecker, 
		                     TimeSpan.FromSeconds(0.5), 
		                     TimeSpan.FromSeconds(10));
		
		
		var test = await Clipboard.GetTextAsync(); 
		await Dialog.Add.InfoAsync("Hello World");
		
		await Dialog.Add.TextToSpeakAsync("Hello World");
		// await Dialog.Dialog.Add.CodeSnippetAsync("Hello World", "lorem ipsum dolor sit amet");

		await PauseAsync("You're done");
		var teste = await Clipboard.GetTextAsync(); 
		
		// await Run.Command.NonInteractiveAsync("dir", "D:\\", stdOut =>
		//                                                          {
		// 	                                                         Dialog.Add.InfoAsync(stdOut); 
		//                                                          },
		//                                           stdErr =>
		//                                           {
		// 	                                          Dialog.Add.ErrorNotationAsync(stdErr);
		//                                           });
		
		
		await PauseAsync(); 
		
		var video = Resolve<Sng_VideoEditor>();
		await video.SplitVideoWhosePathOnClipboardAsync();
		
		var answer = await Dialog.AskUser.ForStringAsync("Please enter your name", input =>
		                                                              {
			                                                              if (string.IsNullOrWhiteSpace(input))
				                                                              return "Your name is required";
			                                                              else return string.Empty;
		                                                              });
		await Dialog.Add.InfoAsync($"Hello {answer}");
		await PauseAsync();
		
		
		await Dialog.Add.WebPageAsync("Google", "Https://www.google.com");
		await PauseAsync();
		
		
		
		
		await Dialog.Add.WindowGrabberAsync("My Company Mail", IsOutlookPwaWindow, () => Task.CompletedTask);
		await PauseAsync();
		await Dialog.Add.WindowGrabberAsync("Vivaldi", IsVivaldi, () => Task.CompletedTask);
		// await PauseAsync();
		// return;
		
		
		
		await Dialog.Add.CodeSnippetAsync("Test code snippet", """
		                                               This is a test code snippet. It's a random text with no specific meaning. The purpose of this text is to test the code snippet feature of Gotcha. The text is written in a lorem ipsum style, with a mix of short and long sentences. The text is filled with words that are not part of the specific context of the test, but are common in the English language. The text is not grammatically correct, but it's not intended to be. The text is meant to be a random collection of words, without any specific meaning or structure. The text is not intended to be read or understood by anyone.
		                                               """);
		
		var result = await Dialog.AskUser.McqAsync("Which one?",
		                               [
			                               new MyOption("Mine"), 
			                               new MyOption("Yours")
		                               ]);

		_ = Dialog.Add.TextToSpeakAsync("This is spoken from the service direct method");
		await Dialog.Add.WarningAsync($"You selected {result.selectedOption}");
		await Dialog.Add.InfoAsync("This is a modeless message box from the service direct method");
		await PauseAsync("Press OK when ready");
		
		await Dialog.Add.WindowGrabberAsync("My Company Mail", IsOutlookPwaWindow, ()=>Task.CompletedTask);
		
		// if (result.isSkipped)
		// {
		// 	await WarnAsync("You skipped the answer");
		// }
		// else
		// {
			await PauseAsync($"You selected {result.selectedOption}");
			
			await Dialog.Add.WindowGrabberAsync("Vivaldi", IsVivaldi, null);
		// }
		await PauseAsync($"You selected {result.selectedOption}");
		
		  
		
		await Dialog.Add.WindowGrabberAsync("My Company Mail", IsOutlookPwaWindow, ()=>Task.CompletedTask);
		
		// await ReportErrorAsync("This is an error from the service direct method");

		// throw new Exception("This is a test exception");

		await PauseAsync();
		
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