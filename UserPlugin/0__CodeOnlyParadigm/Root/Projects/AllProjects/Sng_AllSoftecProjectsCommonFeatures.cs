
[ManualTrigger("💼 All Projects configuration", "All projects")]
public class Sng_AllSoftecProjectsCommonFeatures : SingletonService
{
	public override async Task ExecuteAsync()
	{
		StartOver:
		Context.Dialog.AddOrActivateSideWebPage("💼 All Projects common config", 
		                                        "https://www.notion.so/All-Softec-Projects-Config-32f6ea6ef60880c7bfbeddf361c3c802?source=copy_link");
		
		await Context.Dialog.RouteAsync("What project?", true,
                                            ("Authorize Lens on kubernetes #k8s", 
                                             typeof(Sng_AuthorizeKubernetesLens) ),
                                            ("Manage projects configuration", 
                                             typeof(Sng_AllProjects_ManageConfiguration) )
                                           );

	}
}