
using UserPlugin._GenericServices;

namespace UserPlugin.HabitBuilding;

[ManualTrigger("o1s6c7a", "💻 Start a new project", "Start a new project #create #notion")]
public class Sng_StartNewProject : SingletonService
{
	protected override async Task ExecuteAsync()
	{
		// await Dialog.Add.WebPageAsync()
		// await Dialog.Add.WebPageAsync("Sample",
		//                "https://www.notion.so/9d397c27567e4490a2d8b98cbe0f4640?v=32e6ea6ef608805cbd14000cf1cb5b33&source=copy_link");
		await Notion.OpenAsync("9d397c27567e4490a2d8b98cbe0f4640", "Sample");
		

		await Dialog.Add.TextToSpeakAsync("Remember you almost need the following items for every project");
		await Dialog.Add.TextToSpeakAsync("1. Repos");
		await Dialog.Add.TextToSpeakAsync("2. Architecture");
		await Dialog.Add.TextToSpeakAsync("3. Critical Key Points");
		await Dialog.Add.TextToSpeakAsync("4. Backlog");
		await Dialog.Add.TextToSpeakAsync("5. Reasoning and Decisions"); 
		await PauseAsync("Ready?");
		
		await Dialog.Add.TextToSpeakAsync("Remember also you decided to overview your project through a database filter on a tag.");
		await Dialog.Add.TextToSpeakAsync("As the sample on the left shows, start your project by creating only the Repos with the project's tag. Then add the other pages from the DB filter later.");
		await Dialog.Add.TextToSpeakAsync("Create a new page in Notion, and start by writing /linked to link the MainDB");
		await PauseAsync("Ready?");
		await Dialog.Add.TextToSpeakAsync("Create a filter for the tag that you will create in the same process");
		await PauseAsync("Ready?"); 
		
		await Dialog.Add.TextToSpeakAsync("Copy a link to your database view");
		await PauseAsync("Ready?");
		
		await Dialog.Add.TextToSpeakAsync("In your Gotcha's plug-in. Go to Projects and create Sng_MyNewProject as a service and add it to the Sng_Projects options.");
		await PauseAsync("Ready?");
		
		await Dialog.Add.TextToSpeakAsync("Now the result of the filter is empty. Press the plus sign button to add pages to that view");
		await PauseAsync("Ready?");
		
		_ = Dialog.Add.TextToSpeakAsync("Use the link to in the following similar line to open the page in the project's main page execution!");
		await Dialog.Add.InfoAsync("AddOrActivateSideWebPage(\"Sample\", \"YOUR_LINK_TO_THE_VIEW\"");
		await PauseAsync("Ready?");
		
		
		await Dialog.Add.TextToSpeakAsync("Recall that you may add any other page in a rush and refine them later.");

		await PauseAsync("You're done. Dismiss?");
		// Context.Dismiss();




	}
}