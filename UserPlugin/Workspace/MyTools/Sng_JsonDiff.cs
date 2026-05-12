namespace UserPlugin.Workspace.MyTools;

[ManualTrigger("e2m9m0x", "Compare JSON", "Compares JSON files, diff tool")]
public class Sng_JsonDiff : SingletonService
{   
	protected override async Task ExecuteAsync()    
	{
		await Dialog.Add.WebPageAsync("JSON Diff", "https://semanticdiff.com/online-diff/json/?utm_source=chatgpt.com");
		await Dialog.PauseAsync("You're done");  
		
	}
}