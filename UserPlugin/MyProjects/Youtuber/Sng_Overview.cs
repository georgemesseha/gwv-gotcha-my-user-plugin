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
		await Resolve<Sng_Notion>().GrabNotion("33d6ea6ef60880c2a8cdd227309ea415", "Overview");
		
		await PauseAsync("You're done");
	}
}