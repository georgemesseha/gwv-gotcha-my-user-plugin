using System.Diagnostics;

namespace UserPlugin._GenericServices;

public class Trn_Edge : TransientService
{
	private string[] _expectedTitleWords;
	private string _url = null!;
	
	public async Task OpenAsync(string url, params string[] expectedTitleWords)
	{
		_url = url;
		_expectedTitleWords = expectedTitleWords;
		// var edgePath = @"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe";
		// var process = System.Diagnostics.Process.Start(edgePath, url);
		
		await CaptureWindowAsync("Safe City Portal", WindowPicker, FallbackAction);
	}
	

	
	private async Task FallbackAction()
	{
		Process.Start(new ProcessStartInfo
		{
			FileName = "msedge",
			Arguments = $"--profile-directory=Default --app={_url}",
			UseShellExecute = true
		});
	}
	


	private bool WindowPicker(string title, uint processId)
	{
		title = title.ToLower();
		return _expectedTitleWords.All(w => title.Contains(w))
		&& Process.GetProcessById((int)processId).ProcessName == "msedge";
		// (
		// 	                                                        (
		// 		                                                        // (title.Contains("safe") && title.Contains("city")) || 
		// 		                                                        title.Contains("scg")
		// 	                                                        ) && title.Contains("portal")
		//                                                         );
	}
}