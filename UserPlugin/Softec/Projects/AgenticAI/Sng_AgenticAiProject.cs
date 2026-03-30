
namespace UserPlugin.Softec.Projects.AgenticAI;

[ManualTrigger("Overview", "AgenticAI Project")]
public class Sng_AgenticAiProject : SingletonService
{
	public override async Task ExecuteAsync()
	{
		Context.Dialog.AddOrActivateSideWebPage("AgenticAI Project", "https://www.notion.so/9d397c27567e4490a2d8b98cbe0f4640?v=32e6ea6ef608805cbd14000cf1cb5b33&source=copy_link");
		await Context.Dialog.ShowModalMessageBoxAsync("You're done");
	}
}	