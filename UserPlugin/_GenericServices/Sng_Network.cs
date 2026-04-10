namespace UserPlugin._GenericServices;

public class Sng_Network : SingletonService
{
	public async Task FindProcessWhosePortAsync(int port)
	{
		await RunCommandInTerminalAsync($"netstat -aon | findstr :{port}", "C:\\");
	}

	public async Task PrintCommand_FindProcessWhosePort()
	{
		await this.AddCodeSnippetAsync("To find the process reserving a port", "netstat -aon | findstr :<PORT>");
	}
}