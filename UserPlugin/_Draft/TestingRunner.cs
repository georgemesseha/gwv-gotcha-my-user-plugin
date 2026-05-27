
using UserPlugin.__TEST;

namespace UserPlugin._Draft;

[ManualTrigger("b8r5s6l1z9i5h5")]
public class TestingRunner : SingletonService 
{
    protected override async Task ExecuteAsync()
    {
	    // var runner = new CommandRunner();

	    External.RunPowerShellInteractive("ng new", "D:\\Test");

	    await PauseAsync("You're done");
    }
}