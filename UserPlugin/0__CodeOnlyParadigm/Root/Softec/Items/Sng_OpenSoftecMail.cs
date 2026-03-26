

public class Sng_OpenSoftecMail : SingletonService
{
	string tabSoftecMail => "Softec Mail";
	string urlSoftecMail => "https://outlook.office.com/mail/";
	
	public override async Task ExecuteAsync()
	{
		var commonTabs = Context.Resolve<Sng_CommonTabs>();
		Context.Dialog.AddOrActivateSideWebPage(tabSoftecMail, urlSoftecMail);

		await Context.Dialog.ShowModalMessageBoxAsync("Done?");
	}
}