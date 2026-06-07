
namespace UserPlugin.Workspace.MyTools;

[ManualTrigger("j3m6k1h4s5m1k4")]
public class GEN_PFindMyPhone_7698 : SingletonService 
{
    protected override async Task ExecuteAsync()
	{
		await Edge.OpenAsync("https://myaccount.google.com/find-your-phone?pli=1", "Find My Phone", "phone", "find");
		await PauseAsync("You're done");
	}
}