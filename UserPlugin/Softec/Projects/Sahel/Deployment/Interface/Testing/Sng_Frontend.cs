namespace UserPlugin.Softec.Projects.Sahel.Deployment.Interface.Testing;

[ManualTrigger("e2i8h8s", "Frontend", "Open testing Frontend in browser")]
public class Sng_Frontend : SingletonService
{
	protected override async Task ExecuteAsync()
	{
		await Dialog.Add.InfoAsync("Opening testing frontend in default browser");
		await DefaultBrowser.OpenAsync("https://sahel-testing.20.233.204.79.sslip.io/home");
		await PauseAsync();
	}
}