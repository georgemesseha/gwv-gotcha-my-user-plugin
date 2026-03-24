
[ManualTrigger("Softec", "Softec managerial actions")]
public class Trn_Softec : TransientService
{
	public override async Task ExecuteAsync()
	{
		Context.Dialog.AddOrActivateSideWebPage("Softec", "https://www.notion.so/Softec-2fd6ea6ef60880f6b18ce7df2c37ca97?source=copy_link");
		
		var options = new McqOption[]
		{
			new McqOption("SOD", "Start of day actions", Context.Resolve<Trn_Softec_Sod>()),
			new McqOption("EOD", "End of day actions", Context.Resolve<Trn_Softec_Eod>()),
		};
		
		var result = await Context.Dialog.AskMcqAsync<IService>("Which action do you want to perform?", options);

		if (result.isCancelled)
		{
			return;
		}
		
		await result.optionPayload!.ExecuteAsync();
	}
}