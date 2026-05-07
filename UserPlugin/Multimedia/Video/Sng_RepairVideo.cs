using UserPlugin._GenericServices;

namespace UserPlugin.Multimedia.Video;

[ManualTrigger("k1p9q2f", "Repair Video", "Repair Video, fix, repair, fix video")]
public class Sng_RepairVideo : SingletonService
{
	protected override async Task ExecuteAsync()
	{
		var video = Resolve<Sng_VideoEditor>();
		_ = video.RepairVideosInDirectoryOnClipboardAsync();
        await this.Dialog.Add.InfoAsync("Repairing videos. Keep your eyes on the terminal running the process.");
        await this.Dialog.PauseAsync("Has the process in terminal completed?");
	}
}