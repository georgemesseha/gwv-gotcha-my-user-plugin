
public class Trn_Gotcha_Product_GitRepo : TransientService
{
	public override async Task ExecuteAsync()
	{
		var gotchaMainDirPath = Context.Resolve<Sng_Config_Gotcha>().GotchaMainDirPath;
		await Context.Resolve<Sng_OpenInVsCode>()
		             .OpenDirectory(gotchaMainDirPath);
	}
}