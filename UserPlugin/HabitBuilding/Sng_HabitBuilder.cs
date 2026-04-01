using UserPlugin.HabitBuilding.Items;

namespace UserPlugin.HabitBuilding;

[ManualTrigger("Habit Builder", "Habit Builder")]
public class Sng_HabitBuilder : SingletonService
{
	public override async Task ExecuteAsync()
	{
		await RouteAsync("Pick a habit", false,
		                 ("Organize a project On Notion", typeof(Sng_OrganizeProjectOnNotion)),
		                 ("Start a new project", typeof(Sng_StartNewProject)));
		
	}
}