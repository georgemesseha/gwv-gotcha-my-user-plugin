namespace UserPlugin.Softec.Projects.AgenticAI;

[ManualTrigger("Remote Repo", "Opens the remote repo in the browser")]
public class Sng_RemoteRepo : SingletonService
{
	public override async Task ExecuteAsync()
	{
		OpenInDefaultBrowser("https://dev.azure.com/SoftecMEA/SaaedI/_git/Saaed-Agentic-AI");
	}
}