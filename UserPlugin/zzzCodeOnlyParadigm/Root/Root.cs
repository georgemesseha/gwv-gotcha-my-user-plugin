
using Gwv.Gotcha.Startup;

[ManualTrigger(">>>", "Resembles the root point to branch out hierarically to all of your tasks")]
public class Root : SingletonService
{
	public override  async Task ExecuteAsync()
	{
		Context.Dialog.AddOrActivateSideWebPage("Notion document", "https://www.notion.so");
		await Context.Dialog.AskMcqAsync("Press Enter when ready",  new [] { new McqOption("OK", "") });
		
		Context.Dialog.AddOrActivateSideWebPage("Google", "https://www.google.com");
		Context.Dialog.AddOrActivateSideWebPage("Yahoo", "https://www.yahoo.com");
		Context.Dialog.AddOrActivateSideWebPage("Notion document", "https://www.yahoo.com");
		
		
		await Context.Dialog.InfoAsync("Info");
		_ = Context.Dialog.SpeakAsync("Spoken Info");
		await Context.Dialog.ErrorAsync("Error");
		await Context.Dialog.WarningAsync("Warning");

		var option1 = new McqOption("Yes", "");
		var option2 = new McqOption("No", "");
		var result = await Context.Dialog.AskMcqAsync("Are you sure you want to proceed?", [option1, option2]);

		if (result.SelectedOption == option2)
		{
			Context.MarkForTermination();
			return;
		}
		
		await Context.Dialog.SuccessAsync("Success");
		// Context.SetSideViewUrl("https://www.notion.so/NET-Mid-Senior-Vacancy-3266ea6ef6088087bc25dd92c0b944b2?source=copy_link");
		Console.Beep();
	}
}