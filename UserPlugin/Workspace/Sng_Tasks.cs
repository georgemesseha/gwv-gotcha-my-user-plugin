using UserPlugin._GenericServices;

namespace UserPlugin.Workspace;


[ManualTrigger("j6w1f4v", "", "")]
public class Sng_Tasks : SingletonService
{
	protected override async Task ExecuteAsync()
	{
		
<<<<<<< HEAD
		await Notion.OpenAsync("e180470b73314986ad21b98d61b877be", "Tasks");
=======
		await Resolve<Sng_Notion>().GrabNotion("e180470b73314986ad21b98d61b877be", "Tasks");
>>>>>>> 63f549c01880ff908bec2b9b85f35eddacb85880

		// await Dialog.Add.WebPageAsync("Tasks", "https://www.notion.so/Tasks-e180470b73314986ad21b98d61b877be?source=copy_link");
		await PauseAsync("You're done!");
	}
}