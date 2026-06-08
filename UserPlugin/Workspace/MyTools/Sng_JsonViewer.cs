using UserPlugin._GenericServices;

namespace UserPlugin.Workspace.MyTools;

[ManualTrigger("t7vn1q", "Json viewer", "Opens json viewer")]
public class Sng_JsonViewer : SingletonService
{
	protected override async Task ExecuteAsync()
	{
<<<<<<< HEAD
		await Edge.OpenAsync("https://jsoneditoronline.org/#left=local.kezuqa", "json");
=======
		await Resolve<Trn_Edge>().OpenAsync("https://jsoneditoronline.org/#left=local.kezuqa", "json", "editor");
>>>>>>> 63f549c01880ff908bec2b9b85f35eddacb85880
		
		// await Dialog.Add.WebPageAsync("Json viewer", "https://jsoneditoronline.org/#left=local.kezuqa");
		await PauseAsync("Press Enter to exit");
	}
}