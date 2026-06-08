using UserPlugin._GenericServices;

namespace UserPlugin.Workspace.MyTools.VSCode;

[ManualTrigger("o4p61l", "Create custom snippet", "Creates a custom snippet in VSCode")]
public class Sng_CreateCustomSnippet : SingletonService
{
	protected override async Task ExecuteAsync()
	{
<<<<<<< HEAD
		await Notion.OpenAsync("06411fd9411549c4aadbe118e100f682", "VSCode Snippets Syntax");
=======
		await Resolve<Sng_Notion>().GrabNotion("06411fd9411549c4aadbe118e100f682", "VSCode Snippets Syntax");
>>>>>>> 63f549c01880ff908bec2b9b85f35eddacb85880
		// await Dialog.Add.WebPageAsync("How to create a VSCode snippet",
		//                                    "https://www.notion.so/vscode-code-snippets-syntax-06411fd9411549c4aadbe118e100f682?source=copy_link");
		await PauseAsync();
	}
}