
[ManualTrigger("Workspace", "Contains everyday tasks of managing the workspace.")]
public class Trn_Workspace : TransientService
{
	public override async Task ExecuteAsync()
	{
		var options = new[]
		{
			new McqOption("Arrange windows", 
			              "Arrange/Tile windows of processes/apps",
			              Context.Resolve<Trn_ArrangeWindows>()),
		};
		
		var result = await Context.Dialog.AskMcqAsync<IService>("Which project are you working on?", options);

		if (result.isCancelled || Context.IsMarkedForTermination)
		{
			return;
		}
		
		await result.optionPayload!.ExecuteAsync();

	}
}