using UserPlugin._GenericServices;

namespace UserPlugin.Multimedia.Video;

[ManualTrigger("b8x7x9i", "Split Video", "Split Video, trim, cut, clip")]
public class Sng_SplitVideo : SingletonService
{
	protected override async Task ExecuteAsync()
	{
		var video = Resolve<Sng_VideoEditor>();
		await video.SplitVideoWhosePathOnClipboardAsync();
		await PauseAsync("You're done! Dismiss?");
	}
}