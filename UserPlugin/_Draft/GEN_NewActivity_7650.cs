
using Gwv.Gotcha.Services.Contracts.Plugin.ContextFeatures.ITrn_PluginFeature_External;

namespace UserPlugin._Draft;

[ManualTrigger("j5g7v7e1q2m9e6")]
public class GEN_NewActivity_7650 : SingletonService 
{
    protected override async Task ExecuteAsync()
	{
		var result = await External.DetectExePathAsync("notepad");
		switch (result.status)
		{
			case IScp_PluginFeature_External.Status_DetectExePathAsync.Cancelled:
				break;
			case IScp_PluginFeature_External.Status_DetectExePathAsync.Timeout:
				break;
			case IScp_PluginFeature_External.Status_DetectExePathAsync.Success:
				await Dialog.Add.CodeSnippetAsync("Notepad location", result.exePath);
				break;
			default:
				throw new ArgumentOutOfRangeException();
		}

		await PauseAsync();
	}
}