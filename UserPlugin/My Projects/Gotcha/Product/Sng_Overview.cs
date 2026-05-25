
namespace UserPlugin.My_Projects.Gotcha.Product;

[ManualTrigger("f1o2a5", "Overview", "Gotcha solution Overview")]
public class Sng_Overview : SingletonService
{
	protected override async Task ExecuteAsync()
	{
		await Dialog.Add.WebPageAsync("Gotcha Project", "https://www.notion.so/Gotcha-Project-32f6ea6ef608808ea2afed812fa63f5f?source=copy_link");
		await PauseAsync("You're done");

	}
}