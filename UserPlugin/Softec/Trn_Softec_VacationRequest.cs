
using UserPlugin._GenericServices;

namespace UserPlugin.Softec;

[ManualTrigger("🌴 Vacation Request", "Start of day actions")]
public class Trn_Softec_VacationRequest : TransientService
{
	private const string tabPortalVacationRequest = "Portal: Vacation Request";
	string Tab_VacationRequest => "Vacation Request Instructions";
	string Url_VacationRequestInstructions => "https://www.notion.so/Softec-Send-vacation-request-email-1ba6ea6ef608800d9948c82b21e362f4?source=copy_link";

	string Tab_PortalVacationRequestUIFlow => "Portal: Vacation Request UI Flow";
	string Url_PortalVacationRequestUIFlow => "https://www.notion.so/Saaed-Portal-Vacation-Request-UI-Flow-32e6ea6ef608806c941bd2ca1d65e5b7?source=copy_link";
	string Url_PortalUiFlowOfVacationRequest => "https://www.notion.so/Softec-Send-vacation-request-email-1ba6ea6ef608800d9948c82b21e362f4?source=copy_link#32e6ea6ef60880888e40db1c93c3ff0a";
	
	protected override async Task ExecuteAsync()
	{
		var commonTabs = Resolve<Sng_CommonTabs>();
		
		await Dialog.Add.WebPageAsync(commonTabs.Tab_VacationRequestInstructions, 
		               commonTabs.Url_VacationRequestInstructions);
		
		
		await Dialog.Add.WebPageAsync(tabPortalVacationRequest, commonTabs.Url_SafeCityPortal);
		_ = Dialog.Add.TextToSpeakAsync("Sign in if needed");
		await Dialog.PauseAsync("Done?");

		_ = Dialog.Add.TextToSpeakAsync("Recall the UI flow on the portal on the left!");
		await Dialog.Add.WebPageAsync(Tab_PortalVacationRequestUIFlow, Url_PortalUiFlowOfVacationRequest);
		await Dialog.PauseAsync("Yes I recalled it");

		await Dialog.Add.WebPageAsync(tabPortalVacationRequest, Url_PortalVacationRequestUIFlow);
		_ = Dialog.Add.TextToSpeakAsync("Request the vacation.");
		await Dialog.PauseAsync("Done with request vacation?");

		// Resolve<Sng_OpenSoftecMail>().OpenSideViewForSoftecMail();
		await Resolve<Sng_OpenSoftecMail>().OpenSoftecMailPwaAsync();
		await Dialog.PauseAsync();
		
		await Dialog.Add.WebPageAsync(Tab_VacationRequest, Url_PortalVacationRequestUIFlow);
		await Dialog.Add.TextToSpeakAsync("You got both tabs for the vacation request instructions and the Softec mail. Find your way.");
		
		
		await Dialog.PauseAsync("You're done. Exit?");
		// Context.Dialog.Dismiss();

	}
}