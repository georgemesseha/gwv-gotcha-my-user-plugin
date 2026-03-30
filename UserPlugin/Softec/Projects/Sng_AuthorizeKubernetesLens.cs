
namespace UserPlugin.Softec.Projects;

[ManualTrigger("💻 Authorize Kubernetes Lens", 
               "Authorize Kubernetes Lens for all projects")]
public class Sng_AuthorizeKubernetesLens : SingletonService
{
	public override async Task ExecuteAsync()
	{
		Context.Dialog.AddOrActivateSideWebPage("Authorize Kubernetes Lens", "https://www.notion.so/All-Softec-Projects-Config-32f6ea6ef60880c7bfbeddf361c3c802?source=copy_link#32f6ea6ef6088027ac2be452a8b85db8");
		await Context.Dialog.ShowModalMessageBoxAsync("Check the document and press enter to exit");
	}
}