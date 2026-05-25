namespace UserPlugin._GenericServices;

public class Sng_Git : SingletonService
{
	
	public async Task GetRemoteReposAsync(string workingDir)
	{
		await PrintCommand_GetRemoteReposAsync();
		await PauseAsync();
		
	}
	
	public async Task SetRemoteOriginAsync(string workingDir, string url)
	{
		await PrintCommand_SetRemoteOriginAsync();
		// await Run.Command.InteractiveAsync("git remote set-url origin", workingDir);
		await PauseAsync();
	}
	
	public async Task PrintCommand_GetRemoteReposAsync()
	{
		await this.Dialog.Add.CodeSnippetAsync("To get the current remote repo",
		                               "git remote -v");
	}
	public async Task PrintCommand_SetRemoteOriginAsync()
	{
		await this.Dialog.Add.CodeSnippetAsync("To set the remote origin",
		                               $"git remote set-url origin <url>");
	}
}