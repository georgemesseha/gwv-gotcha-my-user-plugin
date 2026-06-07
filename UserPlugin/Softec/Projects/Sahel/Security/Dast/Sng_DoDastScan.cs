using UserPlugin._GenericServices;

namespace UserPlugin.Softec.Projects.Sahel.Security.Dast;

[ManualTrigger("x3h2y5y", "Do Dast Scan", "Runs a Dast scan")]
public class Sng_DoDastScan : SingletonService
{
	protected override async Task ExecuteAsync()
	{
		await Notion.OpenAsync("3566ea6ef608802a997cf2fec0ace815", "Sahell DAST Overview");
		// await Dialog.Add.WebPageAsync("Sahell DAST Overview",
		//                               "https://www.notion.so/Sahell-DAST-3566ea6ef608802a997cf2fec0ace815?source=copy_link");
		//
		
		// _ = Dialog.Add.WebPageAsync("VeraCode", "https://web.analysiscenter.veracode.com/app/dae/targets");
		await Edge.OpenAsync("https://web.analysiscenter.veracode.com/app/dae/targets", "VeraCode");
		
		await Dialog.Add.InfoAsync("You will need to use Google Authenticator");
		await PauseAsync("Press OK when you are logged in");
		await Dialog.Add.InfoAsync("Navigate to Scans&Analysis/DAST");
		await PauseAsync("Done?");
		await Dialog.Add.InfoAsync("Search for testtt and re-run it");
		await Dialog.Add.WarningAsync("This runs against the Testing branch");
		await PauseAsync("Press OK to dimiss.");
	}
}