
namespace UserPlugin.Workspace.MyTools;

[ManualTrigger("b1l5j4j9l0m5v2")]
public class OpenKoala : SingletonService 
{
    protected override async Task ExecuteAsync()
	{
		await External.RunAndForgetAsync("koala");
	}
}