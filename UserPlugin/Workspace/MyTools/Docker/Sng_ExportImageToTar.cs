namespace UserPlugin.Workspace.MyTools.Docker;

[ManualTrigger("⌛ Export image to tar", "Exports a Docker image to a tar file")]
public class Sng_ExportImageToTar : SingletonService
{
	public override async Task ExecuteAsync()
	{
		await SpeakAsync("This is pending the development of asking for a string question");
		await PauseAsync();
	}
	
	
}