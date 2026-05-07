namespace UserPlugin.Workspace.MyTools.Docker;

[ManualTrigger("u0q1s7o", "⌛ Export image to tar", "Exports a Docker image to a tar file")]
public class Sng_ExportImageToTar : SingletonService
{
	protected override async Task ExecuteAsync()
	{
		await Dialog.Add.TextToSpeakAsync("This is pending the development of asking for a string question");
		await Dialog.PauseAsync();
	}
	
	
}