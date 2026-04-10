using UserPlugin._GenericServices;

namespace UserPlugin.Workspace.MyTools.Network;

[ManualTrigger("Find process whose port ...", "Finds the process that is using a specific port")]
public class Sng_FindProcessWhosePort : SingletonService
{
	public override async Task ExecuteAsync()
	{
		var network = Resolve<Sng_Network>();
		await network.PrintCommand_FindProcessWhosePort();
		await PauseAsync();
	}
}