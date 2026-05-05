namespace UserPlugin._GenericServices;

public class Sng_Network : SingletonService
{
	public async Task FindProcessWhosePortAsync(int port)
	{
		await Run.Command.InteractiveAsync($"netstat -aon | findstr :{port}", "C:\\");
	}

	public async Task PrintCommand_FindProcessWhosePort()
	{
		await this.Dialog.Add.CodeSnippetAsync("To find the process reserving a port", "netstat -aon | findstr :<PORT>");
	}
}