using UserPlugin._GenericServices;

namespace UserPlugin.Fun;

[ManualTrigger("p1l0o7d", "Open Violin tuner", "Opens violin tuner")]
public class Sng_ViolinTuner : SingletonService
{
	protected override async Task ExecuteAsync()
	{
		Resolve<Trn_Edge>().OpenAsync("https://www.violinlounge.com/free-online-violin-tuner-with-mic-and-tuning-notes", "Violin tuner");
		// await Dialog.Add.TextToSpeakAsync("Enjoy violin tuner");
		// await Dialog.Add.WebPageAsync("Violin tuner", "https://www.violinlounge.com/free-online-violin-tuner-with-mic-and-tuning-notes");
		// await PauseAsync("You're done"); 
	}
}