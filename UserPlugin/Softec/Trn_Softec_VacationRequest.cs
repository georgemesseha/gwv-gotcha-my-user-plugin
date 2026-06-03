
using UserPlugin._GenericServices;

namespace UserPlugin.Softec;

[ManualTrigger("r3i1k4e", "🌴 Vacation Request", "Start of day actions")]
public class Trn_Softec_VacationRequest : TransientService
{
	private const string tabPortalVacationRequest = "Portal: Vacation Request";
	string Tab_VacationRequest => "Vacation Request Instructions";
	string Url_VacationRequestInstructions => "https://www.notion.so/Softec-Send-vacation-request-email-1ba6ea6ef608800d9948c82b21e362f4?source=copy_link";

	string Tab_PortalVacationRequestUIFlow => "Portal: Vacation Request UI Flow";
	string Url_PortalVacationRequestUIFlow => "https://www.notion.so/Saaed-Portal-Vacation-Request-UI-Flow-32e6ea6ef608806c941bd2ca1d65e5b7?source=copy_link";
	string NotionId_PortalVacationRequestUIFlow => "32e6ea6ef608806c941bd2ca1d65e5b7";
	
	string Url_PortalUiFlowOfVacationRequest => "https://www.notion.so/Softec-Send-vacation-request-email-1ba6ea6ef608800d9948c82b21e362f4?source=copy_link#32e6ea6ef60880888e40db1c93c3ff0a";
	
	string NotionId_VacationRequestInstructions => "1ba6ea6ef608800d9948c82b21e362f4";
	
	protected override async Task ExecuteAsync()
	{
		var commonTabs = Resolve<Sng_CommonTabs>();
		
		await Resolve<Sng_Notion>().GrabNotion(commonTabs.NotionId_VacationRequestInstructions, Tab_VacationRequest);
		// await Dialog.Add.WebPageAsync(commonTabs.Tab_VacationRequestInstructions, 
		//                commonTabs.Url_VacationRequestInstructions);
		
		
		await Resolve<Sng_SafeCity>().OpenPortalPwaAsync();
		// await Dialog.Add.WebPageAsync(tabPortalVacationRequest, commonTabs.Url_SafeCityPortal);
		
		
		_ = Dialog.Add.TextToSpeakAsync("Sign in if needed");
		await PauseAsync("Done?");

		_ = Dialog.Add.TextToSpeakAsync("Recall the UI flow on the portal on the left!");
		
		await Resolve<Sng_Notion>().GrabNotion(NotionId_VacationRequestInstructions, Tab_PortalVacationRequestUIFlow);
		
		// await Dialog.Add.WebPageAsync(Tab_PortalVacationRequestUIFlow, Url_PortalUiFlowOfVacationRequest);
		await PauseAsync("Yes I recalled it");

		await PauseAsync("Yes I recalled it");
		
		await Resolve<Sng_Notion>().GrabNotion(NotionId_PortalVacationRequestUIFlow, Tab_PortalVacationRequestUIFlow);
		// await Dialog.Add.WebPageAsync(tabPortalVacationRequest, Url_PortalVacationRequestUIFlow);
		
		
		_ = Dialog.Add.TextToSpeakAsync("Request the vacation.");
		await PauseAsync("Done with request vacation?");

		// Resolve<Sng_OpenSoftecMail>().OpenSideViewForSoftecMail();
		await Resolve<Sng_OpenSoftecMail>().OpenSoftecMailPwaAsync();
		await PauseAsync();
		
		
		await Resolve<Sng_Notion>().GrabNotion(NotionId_VacationRequestInstructions, Tab_PortalVacationRequestUIFlow);
		
		// await Dialog.Add.WebPageAsync(Tab_VacationRequest, Url_PortalVacationRequestUIFlow);
		await Dialog.Add.TextToSpeakAsync("You got both tabs for the vacation request instructions and the Softec mail. Find your way.");
		
		
		await PauseAsync("You're done. Exit?");
		// Context.Dialog.Dismiss();

	}
}