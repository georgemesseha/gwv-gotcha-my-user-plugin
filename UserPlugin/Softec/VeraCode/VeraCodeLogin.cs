
using System.Diagnostics;

namespace UserPlugin.Softec.VeraCode;

[ManualTrigger("y1x0d3p3e5d9y3")]
public class VeraCodeLogin : SingletonService 
{
    protected override async Task ExecuteAsync()
	{
		Process.Start(new ProcessStartInfo
		{
			FileName = "msedge",
			Arguments = "--profile-directory=Default --app=https://web.analysiscenter.veracode.com/login/#/login",
			UseShellExecute = true
		});		
		//TODO: Replace the following line with your own code
		await base.ExecuteAsync();
	}
}