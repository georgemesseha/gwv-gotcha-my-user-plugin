namespace UserPlugin.Fun;

[ManualTrigger("Open Violin tuner", "Opens violin tuner")]
public class Sng_ViolinTuner : SingletonService
{
	public override async Task ExecuteAsync()
	{
		Context.Dialog.AddOrActivateSideWebPage("Violin tuner", "https://www.violinlounge.com/free-online-violin-tuner-with-mic-and-tuning-notes");
		await Context.Dialog.ShowModalMessageBoxAsync("You're done"); 
	}
}