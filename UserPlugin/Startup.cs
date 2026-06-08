using Gwv.Cotcha.Services;
using UserPlugin.Workspace.ArrangingWindows;

public class Startup : SingletonService
{
	protected override Task ExecuteAsync()
	{
		Keyboard.RegisterShortcut(Modifier.Ctrl|Modifier.Win, Key.NumPad2, async ()=>
		                                                                   {
			                                                                   // Console.Beep(300, 1000);
			                                                                   _ = Resolve<Trn_ArrangeWindows_Teams>()
				                                                                   .ArrangeWindowsAsync();
		                                                                   });
		return base.ExecuteAsync();
	}
}