
namespace UserPlugin.DotNet.Usual_Development_Tasks;

[ManualTrigger("g6j6i3p6x8e0n2")]
public class SetupCodeFirst : SingletonService 
{
    protected override async Task ExecuteAsync()
    {
	    await Dialog.Add.InfoAsync("First recall the key points in migrations");
	    await Dialog.Add.WebPageAsync("Migration Key Points", "https://www.notion.so/Code-First-Migrations-d1404852408e4bf6a5fdca79d7a980d5?source=copy_link");
	    await PauseAsync();
    }
}