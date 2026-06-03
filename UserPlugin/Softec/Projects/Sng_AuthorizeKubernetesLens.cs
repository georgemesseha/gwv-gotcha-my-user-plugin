
using UserPlugin._GenericServices;

namespace UserPlugin.Softec.Projects;

[ManualTrigger("i2h9o8", "💻 Authorize Kubernetes Lens", 
               "Authorize Kubernetes Lens for all projects")]
public class Sng_AuthorizeKubernetesLens : SingletonService
{
	protected override async Task ExecuteAsync()
	{
		await Resolve<Sng_Notion>().GrabNotion("32f6ea6ef60880c7bfbeddf361c3c802", "Authorize Kubernetes Lens");
		
		// await Dialog.Add.WebPageAsync("Authorize Kubernetes Lens", "https://www.notion.so/All-Softec-Projects-Config-32f6ea6ef60880c7bfbeddf361c3c802?source=copy_link#32f6ea6ef6088027ac2be452a8b85db8");
		await PauseAsync("Check the document and press enter to exit");
	}
}