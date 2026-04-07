namespace UserPlugin.Softec.Projects.AgenticAI;

[ManualTrigger("Local Repo", "Opens Agentic AI local repo")]
public class Sng_LocalRepo : SingletonService
{
	public override async Task ExecuteAsync()
	{
		await RunCommandAsFunctionAsync("cursor .",
		                                "D:\\Projects\\Agentic-AI\\Saaed-Agentic-AI",
		                                false,
		                                null, null);
	}
}