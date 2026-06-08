using UserPlugin._GenericServices;

namespace UserPlugin.Workspace.MyTools.Git;

[ManualTrigger("m7l4s3c", "Untrack a folder or files", "Untracks a folder files from git")]
public class Sng_UntrackFiles : SingletonService
{
	protected override async Task ExecuteAsync()
	{
<<<<<<< HEAD
		await Notion.OpenAsync("4a4d63657f794d50ac34d9a3b87258b2", "Untrack a folder or files");
=======
		await Resolve<Sng_Notion>().GrabNotion("4a4d63657f794d50ac34d9a3b87258b2", "Untrack a folder or files");
>>>>>>> 63f549c01880ff908bec2b9b85f35eddacb85880
		// await Dialog.Add.WebPageAsync("Untrack a folder or files",
		//                                    "https://www.notion.so/Git-How-to-untrack-files-4a4d63657f794d50ac34d9a3b87258b2?source=copy_link");
		await PauseAsync();
	}
}