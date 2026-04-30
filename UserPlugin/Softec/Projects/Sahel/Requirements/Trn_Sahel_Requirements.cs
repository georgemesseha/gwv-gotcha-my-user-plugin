

namespace UserPlugin.Softec.Projects.Sahel.Requirements;

public class Trn_Sahel_Requirements : TransientService
{
	public override async Task ExecuteAsync()
	{
		await Dialog.Add.TextToSpeakAsync("Under construction");
	}
}