namespace UserPlugin.Softec.Projects.Sahel.Requirements;

[ManualTrigger("o7k6q5s", "Task Board", "Opens the new task board")]
public class Trn_Sahel_Requirements : TransientService
{
	protected override async Task ExecuteAsync()
	{
		await
			DefaultBrowser
				.OpenAsync("https://tfs.softecinternational.com/tfs/Softec-MEA/SoftecMEA-SAFe%20Projects/_queries/query/bef2def7-a1ef-42df-a9b1-24b332b15f00/");
		
		// await Edge.OpenAsync("https://tfs.softecinternational.com/tfs/Softec-MEA/SoftecMEA-SAFe%20Projects/_queries/query/bef2def7-a1ef-42df-a9b1-24b332b15f00/", "Task Board", "boards");
		await Dialog.Add.TextToSpeakAsync("Expect it in Vivaldi");
	}
}