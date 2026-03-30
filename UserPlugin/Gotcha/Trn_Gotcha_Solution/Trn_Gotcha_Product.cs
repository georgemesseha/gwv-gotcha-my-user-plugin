
using UserPlugin.Gotcha.Trn_Gotcha_Solution.Items;

namespace UserPlugin.Gotcha.Trn_Gotcha_Solution;

public class Trn_Gotcha_Product : TransientService
{
	public override async Task ExecuteAsync()
	{
		await Context.Dialog.RouteAsync("Action?", true,
		                                ("Develop Gotcha", typeof(Trn_Gotcha_Product_Develop)),
		                                ("Manage Git repo", typeof(Trn_Gotcha_Product_GitRepo))
		                               );

	}
}