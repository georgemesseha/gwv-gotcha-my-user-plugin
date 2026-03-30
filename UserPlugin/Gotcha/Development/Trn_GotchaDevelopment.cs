using UserPlugin.Gotcha.Plugin;
using UserPlugin.Gotcha.Trn_Gotcha_Solution;

namespace UserPlugin.Gotcha.Development;

public class Trn_GotchaDevelopment : TransientService
{
	public override async Task ExecuteAsync()
	{
		await Context.Dialog.RouteAsync("Which one?", true,
		                                ("Solution", typeof(Trn_Gotcha_Product)),
		                                ("Plugin", typeof(Trn_Gotcha_Plugin))
		                               );
		
	}
}