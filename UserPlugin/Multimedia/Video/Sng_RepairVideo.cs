using UserPlugin._GenericServices;

namespace UserPlugin.Multimedia.Video;

[ManualTrigger("Repair Video", "Repair Video, fix, repair, fix video")]
public class Sng_RepairVideo : SingletonService
{
	public override async Task ExecuteAsync()
	{
		var video = Resolve<Sng_VideoEditor>();
		_ = video.RepairVideosInDirectoryOnClipboardAsync();
        await this.Dialog.Add.InfoAsync("Repairing videos. Keep your eyes on the terminal running the process.");
        await this.Dialog.PauseAsync("Has the process in terminal completed?");
	}
}