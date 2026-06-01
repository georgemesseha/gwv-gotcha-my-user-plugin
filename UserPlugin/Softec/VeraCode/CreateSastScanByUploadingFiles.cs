
namespace UserPlugin.Softec.VeraCode;

[ManualTrigger("g3c0z3z5m5o0d8")]
public class CreateSastScanByUploadingFiles : SingletonService 
{
    protected override async Task ExecuteAsync()
	{
		await PauseAsync();
	}
} 