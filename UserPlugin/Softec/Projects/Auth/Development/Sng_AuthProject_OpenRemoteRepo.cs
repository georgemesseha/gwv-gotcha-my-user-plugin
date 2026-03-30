namespace UserPlugin.Softec.Projects.Auth.Development.Items;

[ManualTrigger("Open Softec.Auth Package remote repo", "Open Softec.Auth Package remote repo")]
public class Sng_AuthProject_OpenRemoteRepo : SingletonService
{
	public override async Task ExecuteAsync()
	{
		_ = Context.Dialog.SpeakAsync("Expect it in Vivaldi");
		await Context.Integration.OpenUrlInDefaultBrowserAsync("https://dev.azure.com/SoftecMEA/SaaedI/_git/SaaedAuth");
	}
}