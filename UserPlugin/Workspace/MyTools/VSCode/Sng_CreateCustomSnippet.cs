namespace UserPlugin.Workspace.MyTools.VSCode;

[ManualTrigger("Create custom snippet", "Creates a custom snippet in VSCode")]
public class Sng_CreateCustomSnippet : SingletonService
{
	public override async Task ExecuteAsync()
	{
		await AddOrActivateWebPageTabAsync("How to create a VSCode snippet",
		                                   "https://www.notion.so/vscode-code-snippets-syntax-06411fd9411549c4aadbe118e100f682?source=copy_link");
		await PauseAsync();
	}
}