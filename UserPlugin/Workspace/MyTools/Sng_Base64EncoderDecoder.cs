using UserPlugin._GenericServices;

namespace UserPlugin.Workspace.MyTools;

[ManualTrigger("d2m9i9m", "Base64 Encoder/Decoder", "Encode/Decode Base64")]
public class Sng_Base64EncoderDecoder : SingletonService
{
	protected override async Task ExecuteAsync()
	{
		await Dialog.Add.InfoAsync("Opening base64 encoder/decoder in default browser");
		// await Dialog.Add.WebPageAsync("Base64", "https://www.utilities-online.info/base64");
		await Resolve<Trn_Edge>().OpenAsync("https://www.utilities-online.info/base64", "base64", "encode");
		
		await PauseAsync(); 
	}
}