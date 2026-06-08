using UserPlugin._GenericServices;

namespace UserPlugin.Workspace.MyTools;

[ManualTrigger("e2m9m0x", "Compare JSON", "Compares JSON files, diff tool")]
public class Sng_JsonDiff : SingletonService
{   
	protected override async Task ExecuteAsync()    
	{
<<<<<<< HEAD
		await Edge.OpenAsync("https://semanticdiff.com/online-diff/json/?utm_source=chatgpt.com", "json");
=======
		await Resolve<Trn_Edge>().OpenAsync("https://semanticdiff.com/online-diff/json/?utm_source=chatgpt.com", "json", "diff");
>>>>>>> 63f549c01880ff908bec2b9b85f35eddacb85880
		
		// await Dialog.Add.WebPageAsync("JSON Diff", "https://semanticdiff.com/online-diff/json/?utm_source=chatgpt.com");
		await PauseAsync("You're done");  
		
	}
}