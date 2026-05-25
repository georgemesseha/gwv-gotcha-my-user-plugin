using UserPlugin._GenericServices;

namespace UserPlugin.Workspace.MyTools.Network;

[ManualTrigger("p1n7h7k", "Find process whose port ...", "Finds the process that is using a specific port")]
public class Sng_FindProcessWhosePort : SingletonService
{
	protected override async Task ExecuteAsync()
	{
		var network = Resolve<Sng_Network>();

		await network.FindProcessWhosePortAsync(5101);
		await network.PrintCommand_FindProcessWhosePort();
		await PauseAsync();
	}
}