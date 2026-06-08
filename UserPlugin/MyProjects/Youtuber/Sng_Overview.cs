using UserPlugin._GenericServices;

namespace UserPlugin.MyProjects.Youtuber;

[ManualTrigger("u0s1r6f", "Overview", "Overview")]
public class Sng_Overview : SingletonService
{
	protected override async Task ExecuteAsync()
	{
		// await
		// 	Dialog.Add.WebPageAsync("Overview", "https://www.notion.so/Youtuber-Project-33d6ea6ef60880c2a8cdd227309ea415?source=copy_link");
		//
<<<<<<< HEAD
		await Notion.OpenAsync("33d6ea6ef60880c2a8cdd227309ea415", "Overview");
=======
		await Resolve<Sng_Notion>().GrabNotion("33d6ea6ef60880c2a8cdd227309ea415", "Overview");
>>>>>>> 63f549c01880ff908bec2b9b85f35eddacb85880
		
		await PauseAsync("You're done");
	}
}