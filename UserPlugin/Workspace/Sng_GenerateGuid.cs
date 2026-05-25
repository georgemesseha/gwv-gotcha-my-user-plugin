namespace UserPlugin.Workspace;

[ManualTrigger("0a3f4q", "Generate Guid", "Generates a new Guid")]
public class Sng_GenerateGuid : SingletonService
{ 
	protected override async Task ExecuteAsync()
	{
		_ = Dialog.Add.TextToSpeakAsync("New Guid on the clipboard");
		await Clipboard.SetTextAsync(Guid.NewGuid().ToString());
		await PauseAsync("Press Enter to exit");
	}
}