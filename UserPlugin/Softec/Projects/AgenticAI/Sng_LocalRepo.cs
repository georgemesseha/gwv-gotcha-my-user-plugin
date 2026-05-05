namespace UserPlugin.Softec.Projects.AgenticAI;

[ManualTrigger("Local Repo", "Opens Agentic AI local repo")]
public class Sng_LocalRepo : SingletonService
{
	protected override async Task ExecuteAsync()
	{
		await Integration.ExecNonInteractiveAsync("cursor .",
		                                  "D:\\Projects\\Agentic-AI\\Saaed-Agentic-AI",
		                                  null,
		                                  null);
	}
}