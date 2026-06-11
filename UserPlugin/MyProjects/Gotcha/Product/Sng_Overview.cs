
using UserPlugin._GenericServices;

namespace UserPlugin.MyProjects.Gotcha.Product;

[ManualTrigger("f1o2a5", "Overview", "Gotcha solution Overview")]
public class Sng_Overview : SingletonService
{
	protected override async Task ExecuteAsync()
	{
		await Notion.OpenAsync("32f6ea6ef608808ea2afed812fa63f5f", "Gotcha Project Overview");
		await Notion.OpenAsync("https://app.notion.com/p/Backlog-32f6ea6ef60880d4b0a4d88eb23febc1?source=copy_link",
		                       "Backlog");
		// await DefaultBrowser.OpenAsync("notion://app.notion.com/Gotcha-Project-32f6ea6ef608808ea2afed812fa63f5f?source=copy_link");
		// await GrabAppAsync("Gotcha Project Overview", WindowPicker, FallbackAction); 
		// await Dialog.Add.WebPageAsync("Gotcha Project", "https://www.notion.so/Gotcha-Project-32f6ea6ef608808ea2afed812fa63f5f?source=copy_link");
		await PauseAsync("You're done");

	}

	
	
	
	
	private Task FallbackAction()
	{
		External.RunAndForgetAsync("notion");
		return Task.CompletedTask;
	}

	private bool WindowPicker(string title, uint processId)
	{
		var Process = System.Diagnostics.Process.GetProcessById((int)processId);
		return Process.ProcessName.ToLower() == "notion";
	}
}