namespace UserPlugin.DotNet;

[ManualTrigger("Open nuget.org", "Open nuget.org in the default browser")]
public class Sng_OpenNugetOrg : SingletonService
{
	protected override async Task ExecuteAsync()
	{
		_ = Integration.OpenInDefaultBrowserAsync("https://nuget.org");
		
	}
}