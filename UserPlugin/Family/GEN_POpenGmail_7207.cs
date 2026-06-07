
namespace UserPlugin.Family;

[ManualTrigger("m4w6h7b4s2k2u5")]
public class GEN_POpenGmail_7207 : SingletonService 
{
    protected override async Task ExecuteAsync()
    {
	    await Edge.OpenAsync("https://www.gmail.com", "Gmail", "gmail");
	    await PauseAsync();
    }
}