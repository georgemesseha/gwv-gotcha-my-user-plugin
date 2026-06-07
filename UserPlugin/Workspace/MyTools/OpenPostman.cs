
using System.Diagnostics;

namespace UserPlugin.Workspace.MyTools;

[ManualTrigger("u9a0h2a8u4r7n3")]
public class OpenPostman : SingletonService 
{
    protected override async Task ExecuteAsync()
	{
		_ = Dialog.Add.TextToSpeakAsync("Opening Postman");
		var windowAgent = GetWindowAgent("Postman", WindowPicker, EnsureWindow);
		await windowAgent.CaptureAsync();
		await PauseAsync();
	}

	private async Task EnsureWindow(bool arg)
	{
		await External.RunAndForgetAsync("postman");
	}

	private bool WindowPicker(string title, uint processId)
	{
		var process = Process.GetProcessById((int)processId);
		return process.ProcessName == "Postman";
	}
}