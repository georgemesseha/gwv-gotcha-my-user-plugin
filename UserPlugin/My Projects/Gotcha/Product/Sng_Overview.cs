
namespace UserPlugin.My_Projects.Gotcha.Product;

[ManualTrigger("Overview", "Gotcha solution Overview")]
public class Sng_Overview : SingletonService
{
	public override async Task ExecuteAsync()
	{
		await Dialog.Add.WebPageAsync("Gotcha Project", "https://www.notion.so/Gotcha-Project-32f6ea6ef608808ea2afed812fa63f5f?source=copy_link");
		await Dialog.PauseAsync("You're done");

	}
}