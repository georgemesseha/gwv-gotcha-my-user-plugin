[ManualTrigger("👔 Softec", "Softec managerial actions")]
public class Trn_Softec : TransientService
{
	public override async Task ExecuteAsync()
	{
		Context.Dialog.AddOrActivateSideWebPage("Softec",
		                                        "https://www.notion.so/Softec-2fd6ea6ef60880f6b18ce7df2c37ca97?source=copy_link");


		await Context.Dialog.RouteAsync("Which one?", true,
		                                ("Open mail", typeof(Sng_OpenSoftecMail)),
		                                ("SOD", typeof(Trn_Softec_Sod)),
		                                ("EOD", typeof(Trn_Softec_Eod)),
		                                ("Vacation Request", typeof(Trn_Softec_VacationRequest))
		                               );
	}
}