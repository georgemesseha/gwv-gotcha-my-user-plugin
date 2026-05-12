namespace UserPlugin.DotNet;

[ManualTrigger("t2t6e8d", "Open nuget.org", "Open nuget.org in the default browser")]
public class Sng_OpenNugetOrg : SingletonService
{
	protected override async Task ExecuteAsync()
	{
		_ = DefaultBrowser.OpenAsync("https://nuget.org");   
		
	}
}