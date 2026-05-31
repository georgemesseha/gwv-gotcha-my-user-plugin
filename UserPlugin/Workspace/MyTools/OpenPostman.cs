
namespace UserPlugin.Workspace.MyTools;

[ManualTrigger("u9a0h2a8u4r7n3")]
public class OpenPostman : SingletonService 
{
    protected override async Task ExecuteAsync()
	{
		await External.RunAndForgetAsync("postman");
		_ = Dialog.Add.TextToSpeakAsync("Opening Postman");
	}
}