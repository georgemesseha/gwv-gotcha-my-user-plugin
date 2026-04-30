namespace UserPlugin.Fun;

[ManualTrigger("Open Violin tuner", "Opens violin tuner")]
public class Sng_ViolinTuner : SingletonService
{
	public override async Task ExecuteAsync()
	{
		await Dialog.Add.WebPageAsync("Violin tuner", "https://www.violinlounge.com/free-online-violin-tuner-with-mic-and-tuning-notes");
		await Dialog.PauseAsync("You're done"); 
	}
}