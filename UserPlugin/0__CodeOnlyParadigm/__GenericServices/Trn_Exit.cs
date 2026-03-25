
public class Trn_Exit : TransientService
{
	public override async Task ExecuteAsync()
	{
		Context.Dialog.Dismiss();
	}
}