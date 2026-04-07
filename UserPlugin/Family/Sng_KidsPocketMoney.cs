namespace UserPlugin.Family;

[ManualTrigger("Kids Pocket Money", "Manage kids pocket money")]
public class Sng_KidsPocketMoney : SingletonService
{
	public override async Task ExecuteAsync()
	{
		await AddOrActivateWebPageTabAsync("Kids Pocket Money", "https://www.notion.so/Kids-Pocket-Money-31c6ea6ef60880ef87a8c132c1a97b99?source=copy_link");
		await PauseAsync("You're done");
	}
}