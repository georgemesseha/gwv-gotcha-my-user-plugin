namespace UserPlugin.Fun;

[ManualTrigger("p1l0o7d", "Open Violin tuner", "Opens violin tuner")]
public class Sng_ViolinTuner : SingletonService
{
	protected override async Task ExecuteAsync()
	{
		await Dialog.Add.WebPageAsync("Violin tuner", "https://www.violinlounge.com/free-online-violin-tuner-with-mic-and-tuning-notes");
		await Dialog.PauseAsync("You're done"); 
	}
}