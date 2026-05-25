namespace UserPlugin.Workspace.PersonalLaptop;

[ManualTrigger("w6l8c6t", "Download Drivers", "Downloads drivers, update, install, Dell")]
public class Sng_DownloadDrivers : SingletonService
{
	protected override async Task ExecuteAsync()
	{
		_ = Dialog.Add.TextToSpeakAsync("Openning drivers resource page in default browser");
		await DefaultBrowser.OpenAsync("https://www.dell.com/support/product-details/en-us/product/inspiron-15-5570-laptop/drivers");
		await PauseAsync();
	}
}