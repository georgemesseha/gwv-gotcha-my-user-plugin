namespace UserPlugin.Softec.Projects.Sahel.Security.Dast;

[ManualTrigger("uj7t3a6x", "", "")]
public class Sng_DoSastScan : SingletonService 
{
	protected override async Task ExecuteAsync()
	{
		await this.DefaultBrowser.OpenAsync("https://dev.azure.com/SoftecMEA/Sahel/_build?definitionId=620");
		await Dialog.Add.WebPageAsync("SAST Scan Instructions", "https://www.notion.so/Run-SAST-pipeline-scan-2566ea6ef608809ba8fdd7299c09e299?source=copy_link");
		await Dialog.PauseAsync("You are done!"); 
	}
}  