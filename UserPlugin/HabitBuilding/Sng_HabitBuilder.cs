using UserPlugin.HabitBuilding.Items;

namespace UserPlugin.HabitBuilding;

[ManualTrigger("Habit Builder", "Habit Builder")]
public class Sng_HabitBuilder : SingletonService
{
	public override async Task ExecuteAsync()
	{
		var service = await Context.Dialog.PickServiceAsync("Pick a habit?",
		                                                    ("Organize a project On Notion", typeof(Sng_OrganizeProjectOnNotion)),
		                                                    ("Start a new project", typeof(Sng_StartNewProject))
		                                                    );
		await service.ExecuteAsync();
	}
}