
using Gwv.Gotcha.Startup;
using UserPlugin._0__CodeOnlyParadigm.Root.HabbitBuilder;

[ManualTrigger(">>>", "Resembles the root point to branch out hierarically to all of your tasks")]
public class Sng_Root : SingletonService
{
	public override  async Task ExecuteAsync()
	{
		var service = await Context.Dialog.PickServiceAsync("Category?",
		                                              ("Projects", typeof(Trn_Projects)),
		                                              ("Workspace", typeof(Trn_Workspace)),
		                                              ("Softec", typeof(Trn_Softec)),
		                                              ("Knowledge Recall", typeof(Sng_KnowledgeRecall)),
		                                              ("Habbit Builder", typeof(Sng_HabitBuilder)));

		await service.ExecuteAsync();
		// var options = new[]
		// {
		// 	new McqOption("Projects", "Projects", Context.Resolve<Trn_Projects>()),
		// 	new McqOption("Workspace", "Workspace", Context.Resolve<Trn_Workspace>()),
		// };
		//
		// int count = options.Length;
		// var result = await Context.Dialog.AskMcqAsync<IService>("Category?", options);
		// if (result.isCancelled) return;
		//
		// await result.optionPayload!.ExecuteAsync();

		// Context.Dialog.AddOrActivateSideWebPage("Notion document", "https://www.notion.so");
		// await Context.Dialog.AskMcqAsync("Press Enter when ready",  new [] { new McqOption("OK", "") });
		//
		// Context.Dialog.AddOrActivateSideWebPage("Google", "https://www.google.com");
		// Context.Dialog.AddOrActivateSideWebPage("Yahoo", "https://www.yahoo.com");
		// Context.Dialog.AddOrActivateSideWebPage("Notion document", "https://www.yahoo.com");
		//
		//
		// await Context.Dialog.InfoAsync("Info");
		// _ = Context.Dialog.SpeakAsync("Spoken Info");
		// await Context.Dialog.ErrorAsync("Error");
		// await Context.Dialog.WarningAsync("Warning");
		//
		// var option1 = new McqOption("Yes", "");
		// var option2 = new McqOption("No", "");
		// var result = await Context.Dialog.AskMcqAsync("Are you sure you want to proceed?", [option1, option2]);
		//
		// if (result.SelectedOption == option2)
		// {
		// 	Context.MarkForTermination();
		// 	return;
		// }
		//
		// await Context.Dialog.SuccessAsync("Success");
		// Console.Beep();
	}
}