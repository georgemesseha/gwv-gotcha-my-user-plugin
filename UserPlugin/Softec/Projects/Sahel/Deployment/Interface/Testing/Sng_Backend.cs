namespace UserPlugin.Softec.Projects.Sahel.Deployment.Interface.Testing;

[ManualTrigger("v4p2r7w", "Backend", "Open testing Backend in browser")]
public class Sng_Backend : SingletonService
{
	protected override async Task ExecuteAsync()
	{
		await Dialog.Add.InfoAsync("Opening testing backend in default browser");
		await DefaultBrowser.OpenAsync("https://sahel-api-testing.kindmoss-593daa5f.uaenorth.azurecontainerapps.io/api/ServiceCategory/GetAllServicesCategoriesWithServices?ln=ar-EG");
		await PauseAsync();
	}
}