namespace UserPlugin.Softec.Projects.AgenticAI;

[ManualTrigger("c0r7s3x", "Remote Repo", "Opens the remote repo in the browser")]
public class Sng_RemoteRepo : SingletonService
{
	protected override async Task ExecuteAsync()
	{
		_ = DefaultBrowser.OpenAsync("https://dev.azure.com/SoftecMEA/SaaedI/_git/Saaed-Agentic-AI");
	}
}