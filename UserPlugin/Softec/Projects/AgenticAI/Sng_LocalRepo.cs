namespace UserPlugin.Softec.Projects.AgenticAI;

[ManualTrigger("ub9d90c", "Local Repo", "Opens Agentic AI local repo")]
public class Sng_LocalRepo : SingletonService
{
	protected override async Task ExecuteAsync()
	{
		// await Run.Command.NonInteractiveAsync("cursor .",
		//                                   "D:\\Projects\\Agentic-AI\\Saaed-Agentic-AI",
		//                                   null,
		//                                   null);
		
		_ = Dialog.Add.TextToSpeakAsync("Opening Agentic AI repo in Cursor ...");
		
		await External.RunPowerShellAsync("cursor .",
		                                      "D:\\Projects\\Agentic-AI\\Saaed-Agentic-AI",
		                                      null,
		                                      null);

		
		// await PauseAsync("Done?");
	}
}