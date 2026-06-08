
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
	
	string NotionId_VacationRequestInstructions => "https://app.notion.com/p/Softec-Send-vacation-request-email-1ba6ea6ef608800d9948c82b21e362f4?source=copy_link#32e6ea6ef60880888e40db1c93c3ff0a";
	
	protected override async Task ExecuteAsync()
	{
		_ = Dialog.Add.TextToSpeakAsync("Fill in a Leave request.");
		await Resolve<Sng_SafeCity>().OpenPortalPwaAsync();
		await PauseAsync();
		
		await Resolve<Sng_OpenSoftecMail>().OpenSoftecMailPwaAsync();
		_ = Dialog.Add.TextToSpeakAsync("Start a new message");
		await PauseAsync();
		
		_ = Dialog.Add.TextToSpeakAsync("Fill the 'Mail To' field");
		_ = Dialog.Add.CodeSnippetAsync("Mail To", "ahmed.fares@softec.com; hr@softec.com");
		await PauseAsync();
		
		
		_ = Dialog.Add.TextToSpeakAsync("Fill the 'Subject' field");
		_ = Dialog.Add.CodeSnippetAsync("Mail Subject", "Vacation Request");
		await PauseAsync();
		
		_ = Dialog.Add.TextToSpeakAsync("Update your own records with this vacation!");
		await Notion.OpenAsync("https://app.notion.com/p/Softec-Send-vacation-request-email-1ba6ea6ef608800d9948c82b21e362f4?source=copy_link#1ba6ea6ef60880ddbea8cb8fa6ecb201", 
		                       Tab_PortalVacationRequestUIFlow);
		await PauseAsync();
		
		_ = Dialog.Add.TextToSpeakAsync("You're done with vacation request");

		await PauseAsync("Exit?");


	}
}