
namespace UserPlugin.Gotcha.Product;

[ManualTrigger("Overview", "Gotcha solution Overview")]
public class Sng_Overview : SingletonService
{
	public override async Task ExecuteAsync()
	{
		AddOrActivateWebPageTab("Gotcha Project", "https://www.notion.so/Gotcha-Project-32f6ea6ef608808ea2afed812fa63f5f?source=copy_link");
		await PauseAsync("You're done");

	}
}