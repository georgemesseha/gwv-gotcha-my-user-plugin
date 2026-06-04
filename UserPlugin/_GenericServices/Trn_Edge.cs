using System.Diagnostics;

namespace UserPlugin._GenericServices;

public class Trn_Edge : TransientService
{
	private string[] _expectedTitleWords = [];
	private string _url = null!;
	private string _tabTitle = null!;
	
	public async Task OpenAsync(string url, string tabTitle, params string[] expectedTitleWords)
	{
		if (expectedTitleWords.Any() == false)
		{
			throw new InvalidOperationException("You must provide title words for matching the Edge window");
		}
		
		_url = url;
		_tabTitle = tabTitle;
		_expectedTitleWords = expectedTitleWords.Select(w => w.ToLower()).ToArray();
		
		
		// var edgePath = @"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe";
		// var process = System.Diagnostics.Process.Start(edgePath, url);
		
		await CaptureWindowAsync(tabTitle, WindowPicker, FallbackAction);
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
		string processName = Process.GetProcessById((int)processId).ProcessName.ToLower();
		bool isEdge = processName == "msedge";
		
		title = title.ToLower();
		return isEdge && _expectedTitleWords.All(w => title.Contains(w));
		
	}
}