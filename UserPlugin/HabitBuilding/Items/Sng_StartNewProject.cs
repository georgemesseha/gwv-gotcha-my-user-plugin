
namespace UserPlugin.HabitBuilding.Items;

[ManualTrigger("💻 Start a new project", "Start a new project #create #notion")]
public class Sng_StartNewProject : SingletonService
{
	public override async Task ExecuteAsync()
	{
		AddSideWebPage("Sample",
		               "https://www.notion.so/9d397c27567e4490a2d8b98cbe0f4640?v=32e6ea6ef608805cbd14000cf1cb5b33&source=copy_link");

		await SpeakAsync("Remember you almost need the following items for every project");
		await SpeakAsync("1. Repos");
		await SpeakAsync("2. Architecture");
		await SpeakAsync("3. Critical Key Points");
		await SpeakAsync("4. Backlog");
		await SpeakAsync("5. Reasoning and Decisions");
		await PauseAsync("Ready?");
		
		await SpeakAsync("Remember also you decided to overview your project through a database filter on a tag.");
		await SpeakAsync("As the sample on the left shows, start your project by creating only the Repos with the project's tag. Then add the other pages from the DB filter later.");
		await SpeakAsync("In Notion, go to your main DB and create a filter for that tag.");
		await PauseAsync("Ready?");
		
		await SpeakAsync("In your Gotcha's plug-in. Go to Projects and create Sng_MyNewProject as a service and add it to the Sng_Projects options.");
		await PauseAsync("Ready?");
		
		await SpeakAsync("Copy a link to your database view");
		await PauseAsync("Ready?");
		
		await InformAsync("AddOrActivateSideWebPage(\"Sample\", \"YOUR_LINK_TO_THE_VIEW\"");
		await SpeakAsync("Use the link to in the following similar line to open the page in the project's main page execution!");
		await PauseAsync("Ready?");
		
		
		await SpeakAsync("Recall that you may add any other page in a rush and refine them later.");

		await PauseAsync("You're done. Dismiss?");
		// Context.Dismiss();




	}
}