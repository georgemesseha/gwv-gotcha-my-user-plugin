using UserPlugin._GenericServices;

namespace UserPlugin.Family;

[ManualTrigger("h9t9f3s", "Kids Pocket Money", "Manage kids pocket money")]
public class Sng_KidsPocketMoney : SingletonService
{
	protected override async Task ExecuteAsync()
	{
		await Resolve<Sng_Notion>().GrabNotion("31c6ea6ef60880ef87a8c132c1a97b99", "Kids Pocket Money");
		// await Dialog.Add.WebPageAsync("Kids Pocket Money", "https://www.notion.so/Kids-Pocket-Money-31c6ea6ef60880ef87a8c132c1a97b99?source=copy_link");
		await PauseAsync("You're done");
	}
}