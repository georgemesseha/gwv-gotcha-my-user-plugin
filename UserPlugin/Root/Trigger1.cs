using System.Diagnostics;
using Gwv.Gotcha;
using Gwv.Gotcha.Services;
using Gwv.Gotcha.Services.Plugin;
using Gwv.Gotcha.Startup;


namespace UserPlugin.Root;

[ManualTrigger("This is a powerful trigger", "This is a manual trigger")]
public class Trigger1 : TransientService
{
	public override async Task ExecuteAsync()
	{
		Stopwatch stopwatch = new();
		stopwatch.Start();

		
		for (int i = 0; i < 20; i++)
		{
			if (Context.IsMarkedForTermination)
			{
				return;
			}
			await Task.Delay(1000);
			Console.Beep(200, 300);
		}

		await Context.Integration.RunInTerminal("dir", "");
		// throw new Exception("This is an intended exception");
		// Context.Services.Clipboard.SetText("This text is from the plug-in");
		await Context.Dialog.SpeakAsync("Test");
		Context.StatusMessage = "This is a status message written by the plug-in";
		// await Context.Services.VideoEditor.CreateWorkshopForFilePathOnClipboardAsync();
		await Task.Run(async () =>
		               {
			               while (true)
			               {
				               // Console.Beep();

				               
				               Thread.Sleep(5000);

				               var result = await 
					                            Context.Dialog.AskMcqAsync("Is this your first MCQ in this invention?", new[]
					                            {
						                            new McqOption("Yes", "Yes"),
						                            new McqOption("No", "No")
					                            });
				               _ = Context.Dialog.SpeakAsync(result.SelectedOption?.title ?? "Cancelled");

				               if (Context.IsMarkedForTermination)
				               {
					               return;
				               }
			               }
		               });
		
		

		
	
		
	}
}