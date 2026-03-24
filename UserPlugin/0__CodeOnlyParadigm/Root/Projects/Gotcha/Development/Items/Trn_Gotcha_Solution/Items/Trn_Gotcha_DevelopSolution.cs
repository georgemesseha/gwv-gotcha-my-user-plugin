
[ManualTrigger("Develop Gotcha Solution", "Develop Gotcha Solution", false)]
public class Trn_Gotcha_DevelopSolution : TransientService
{
	public override async Task ExecuteAsync()
	{
		var gotchaSlnFilePath = Context.Resolve<Sng_Config_Gotcha>().GotchaSlnFilePath;
		await Context.Resolve<Sng_OpenInRider>().OpenSolutionAsync(gotchaSlnFilePath);
	}
}