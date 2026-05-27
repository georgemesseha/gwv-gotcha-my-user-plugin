
using UserPlugin.__TEST;

namespace UserPlugin.Workspace.MyTools.AI_Agents;

[ManualTrigger("i2d5b1b3l0a1y8")]
public class OpenCodex : SingletonService 
{
    protected override async Task ExecuteAsync()
	{
		// var runner = new CommandRunner();
		External.OpenWithDefaultApp("codex:");
		// runner.OpenWithDefaultApp("codex:");

	}
}