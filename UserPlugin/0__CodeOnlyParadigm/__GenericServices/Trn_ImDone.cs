
public class Trn_ImDone : TransientService
{
	public override async Task ExecuteAsync()
	{
		Context.Dialog.Dismiss();
	}
}