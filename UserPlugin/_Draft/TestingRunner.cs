
using YourApp.Processes;

namespace UserPlugin._Draft;

[ManualTrigger("b8r5s6l1z9i5h5")]
public class TestingRunner : SingletonService 
{
    protected override async Task ExecuteAsync()
    {
	    var runner = new CommandRunner();

	    runner.OpenWithDefaultApp("codex:");
	    runner.RunPowerShellInteractive("ng new", "D:\\Test");

	    await PauseAsync("You're done");
    }
}