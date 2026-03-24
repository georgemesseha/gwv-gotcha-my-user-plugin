
[ManualTrigger("Arrange windows ...", "Arrange/Tile windows of processes/apps")]
public class Trn_ArrangeWindows : TransientService
{
	public override async Task ExecuteAsync()
	{
		var options = new[]
		{
			new McqOption("Vivaldi", 
			              "Arrange/Tile windows of Vivaldi", 
			              Context.Resolve<Trn_ArrangeWindows_Vivaldi>()),
			new McqOption("Edge", 
			              "Arrange/Tile windows of Edge", 
			              Context.Resolve<Trn_ArrangeWindows_Edge>()),
			new McqOption("Terminal", 
			              "Arrange/Tile windows of Terminal", 
			              Context.Resolve<Trn_ArrangeWindows_Terminal>()),
			new McqOption("VSCode", 
			              "Arrange/Tile windows of VSCode",
			              Context.Resolve<Trn_ArrangeWindows_VSCode>()),
			new McqOption("Teams", 
			              "Arrange/Tile windows of Teams", 
			              Context.Resolve<Trn_ArrangeWindows_Teams>()),
			new McqOption("Rider", 
			              "Arrange/Tile windows of Rider",
			              Context.Resolve<Trn_ArrangeWindows_Rider>()),
			new McqOption("Postman", 
			              "Arrange/Tile windows of Postman", 
			              Context.Resolve<Trn_ArrangeWindows_Postman>()),
			new McqOption("Notion", 
			              "Arrange/Tile windows of Notion", 
			              Context.Resolve<Trn_ArrangeWindows_Notion>()),
		};

		var result = await Context.Dialog.AskMcqAsync<IService>("Which App?", options);

		if (result.isCancelled || Context.IsMarkedForTermination)
		{
			return;
		}


		await result.optionPayload!.ExecuteAsync();

	}
}