
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace UserPlugin.Workspace;

[ManualTrigger("q5p1z9w0l9u3u2")]
public class OpenDownloadsFolder : SingletonService 
{

	
	// This is the unique identifier for the Downloads folder
	private static readonly Guid DownloadsGuid = new Guid("374DE290-123F-4565-9164-39C4925E467B");

	[DllImport("shell32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, PreserveSig = false)]
	private static extern string SHGetKnownFolderPath([MarshalAs(UnmanagedType.LPStruct)] Guid rfid, uint dwFlags, IntPtr hToken);

	public static void Open()
	{
		try
		{
			// Get the actual path of the Downloads folder
			string downloadsPath = SHGetKnownFolderPath(DownloadsGuid, 0, IntPtr.Zero);

			// Open the folder in Windows Explorer
			Process.Start("explorer.exe", downloadsPath);
		}
		catch (Exception ex)
		{
			// Handle cases where the folder might be missing or inaccessible
			Console.WriteLine($"An error occurred: {ex.Message}");
		}
	}

	
    protected override async Task ExecuteAsync()
	{
		Open();
	}
}