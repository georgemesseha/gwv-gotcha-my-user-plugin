using UserPlugin._GenericServices;

namespace UserPlugin.Fun;

[ManualTrigger("Grab wallpapers", "Grabs wallpapers from the lock screen")]
public class Sng_GrabWallpapers : SingletonService
{
	public override async Task ExecuteAsync()
	{
		string userProfileFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
		var spotListDirPath = Path.Join(userProfileFolder, @"AppData\Local\Packages\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\LocalState\Assets");
		var bingImagePath = Path.Join(userProfileFolder, @"\AppData\Roaming\Microsoft\Windows\Themes\TranscodedWallpaper");
		
		var spotLightFiles = new DirectoryInfo(spotListDirPath).GetFiles().Where(f=>f.Length > 100000).ToArray();
		
		
		var tempDir = Directory.CreateDirectory(Path.Join(Path.GetTempPath(), Path.GetRandomFileName()));
		foreach(var f in spotLightFiles)
		{
			var dstn = Path.Join(tempDir.FullName, $"{f.Name}.jpeg");
			f.CopyTo(dstn);
		}
		
		var bingImageFile = new FileInfo(bingImagePath);

		if(bingImageFile.Exists)
		{
			bingImageFile.CopyTo(Path.Join(tempDir.FullName, $"{bingImageFile.Name}.jpg"));
		}
		
		var explorer = Resolve<Sng_OpenInExplorer>();
		await explorer.OpenFolderAsync(tempDir.FullName);
	}
}