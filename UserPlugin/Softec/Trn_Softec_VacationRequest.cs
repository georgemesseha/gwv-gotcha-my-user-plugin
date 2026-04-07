
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
	
	public override async Task ExecuteAsync()
	{
		var commonTabs = Resolve<Sng_CommonTabs>();
		
		await AddOrActivateWebPageTabAsync(commonTabs.Tab_VacationRequestInstructions, 
		               commonTabs.Url_VacationRequestInstructions);
		
		
		await AddOrActivateWebPageTabAsync(tabPortalVacationRequest, commonTabs.Url_SafeCityPortal);
		_ = SpeakAsync("Sign in if needed");
		await PauseAsync("Done?");

		_ = SpeakAsync("Recall the UI flow on the portal on the left!");
		await AddOrActivateWebPageTabAsync(Tab_PortalVacationRequestUIFlow, Url_PortalUiFlowOfVacationRequest);
		await PauseAsync("Yes I recalled it");

		await AddOrActivateWebPageTabAsync(tabPortalVacationRequest, Url_PortalVacationRequestUIFlow);
		_ = SpeakAsync("Request the vacation.");
		await PauseAsync("Done with request vacation?");

		// Resolve<Sng_OpenSoftecMail>().OpenSideViewForSoftecMail();
		await Resolve<Sng_OpenSoftecMail>().OpenSoftecMailPwaAsync();
		await PauseAsync();
		
		await AddOrActivateWebPageTabAsync(Tab_VacationRequest, Url_PortalVacationRequestUIFlow);
		await SpeakAsync("You got both tabs for the vacation request instructions and the Softec mail. Find your way.");
		
		
		await PauseAsync("You're done. Exit?");
		// Context.Dialog.Dismiss();

	}
}