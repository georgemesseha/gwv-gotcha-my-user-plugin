namespace UserPlugin._0__CodeOnlyParadigm.Root.HabbitBuilder;

[ManualTrigger("Habit Builder", "Habit Builder")]
public class Sng_HabitBuilder : SingletonService
{
	public override async Task ExecuteAsync()
	{
		var service = await Context.Dialog.PickServiceAsync("What project?",
		                                                    ("Organize a project On Notion", typeof(Sng_OrganizeProjectOnNotion))
		                                                    );
		await service.ExecuteAsync();
	}
}