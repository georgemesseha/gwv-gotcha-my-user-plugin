namespace UserPlugin.Workspace;


[ManualTrigger("j6w1f4v", "", "")]
public class Sng_Tasks : SingletonService
{
	protected override async Task ExecuteAsync()
	{

		await Dialog.Add.WebPageAsync("Tasks", "https://www.notion.so/Tasks-e180470b73314986ad21b98d61b877be?source=copy_link");
		await Dialog.PauseAsync("You're done!");
	}
}