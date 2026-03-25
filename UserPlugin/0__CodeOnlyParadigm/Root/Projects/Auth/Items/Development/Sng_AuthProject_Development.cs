
public class Sng_AuthProject_Development : SingletonService
{

	public override async Task ExecuteAsync()
	{
		var service = await Context.Dialog.PickServiceAsync("What do you want to do?",
		                                                    ("Open solution", typeof(Sng_AuthProject_OpenSolution))
		                                                    );
		await service.ExecuteAsync();
		
	}
}