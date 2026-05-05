
namespace UserPlugin.Softec.Projects.AgenticAI;

[ManualTrigger("Overview", "AgenticAI Project")]
public class Sng_AgenticAiProject : SingletonService
{
	protected override async Task ExecuteAsync()
	{
		await Dialog.Add.WebPageAsync("AgenticAI Project", "https://www.notion.so/9d397c27567e4490a2d8b98cbe0f4640?v=32e6ea6ef608805cbd14000cf1cb5b33&source=copy_link");
		await Dialog.PauseAsync("You're done");
	}
}	