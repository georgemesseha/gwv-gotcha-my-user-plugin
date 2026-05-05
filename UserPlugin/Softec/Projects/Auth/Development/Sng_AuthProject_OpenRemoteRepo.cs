namespace UserPlugin.Softec.Projects.Auth.Development;

[ManualTrigger("Open remote repo", "Open Softec.Auth Package remote repo")]
public class Sng_AuthProject_OpenRemoteRepo : SingletonService
{
	protected override async Task ExecuteAsync()
	{
		_ = Dialog.Add.TextToSpeakAsync("Opening Auth remote repo in Vivaldi");
		_ = DefaultBrowser.OpenAsync("https://dev.azure.com/SoftecMEA/SaaedI/_git/SaaedAuth");
		
		
	}
}