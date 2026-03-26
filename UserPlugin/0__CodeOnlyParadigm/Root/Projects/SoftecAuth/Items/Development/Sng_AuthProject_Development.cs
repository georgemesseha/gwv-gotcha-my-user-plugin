
public class Sng_AuthProject_Development : SingletonService
{

	public override async Task ExecuteAsync()
	{
		await Context.Dialog.RouteAsync("What do you want to do?", true,
		                                                    ("Open solution", typeof(Sng_AuthProject_OpenSolution)),
		                                                    ("Open remote repo", typeof(Sng_AuthProject_OpenRemoteRepo))
		                                                    );

		
	}
}