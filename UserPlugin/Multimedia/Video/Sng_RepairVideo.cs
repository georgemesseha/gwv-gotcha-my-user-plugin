using UserPlugin._GenericServices;

namespace UserPlugin.Multimedia.Video;

[ManualTrigger("Repair Video", "Repair Video, fix, repair, fix video")]
public class Sng_RepairVideo : SingletonService
{
	public override async Task ExecuteAsync()
	{
		var video = Resolve<Sng_VideoEditor>();
		await video.RepairVideosInDirectoryOnClipboardAsync();
	}
}