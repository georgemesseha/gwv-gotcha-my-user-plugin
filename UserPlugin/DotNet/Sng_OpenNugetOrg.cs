namespace UserPlugin.DotNet;

[ManualTrigger("Open nuget.org", "Open nuget.org in the default browser")]
public class Sng_OpenNugetOrg : SingletonService
{
	public override async Task ExecuteAsync()
	{
		OpenInDefaultBrowser("https://nuget.org");
		
	}
}