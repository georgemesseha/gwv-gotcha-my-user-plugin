using UserPlugin._GenericServices;

namespace UserPlugin.Multimedia.Video;

[ManualTrigger("Split Video", "Split Video, trim, cut, clip")]
public class Sng_SplitVideo : SingletonService
{
	public override async Task ExecuteAsync()
	{
		var video = Resolve<Sng_VideoEditor>();
		await video.SplitVideoWhosePathOnClipboardAsync();
	}
}