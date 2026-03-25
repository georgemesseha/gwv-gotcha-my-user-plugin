
public class Trn_AuthProject_Publishing : TransientService
{

	public override async Task ExecuteAsync()
	{
		var commonTabs = Context.Resolve<Sng_CommonTabs>();
		Context.Dialog.AddOrActivateSideWebPage(commonTabs.Tab_SoftecAuthProjectMainPage, 
		                                        commonTabs.Url_SoftecAuthProjectMainPage);
		
	}
}