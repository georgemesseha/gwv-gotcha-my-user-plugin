using Gwv.Cotcha.Services;
using UserPlugin.Workspace.ArrangingWindows;

namespace UserPlugin;

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
		Keyboard.RegisterShortcut(Modifier.Ctrl|Modifier.Win, Key.NumPad4, async ()=>
		                                                                   {
			                                                                   // Console.Beep(300, 1000);
			                                                                   _ = Resolve<Trn_ArrangeWindows_Rider>()
				                                                                   .ArrangeWindowsAsync();
		                                                                   });
		Keyboard.RegisterShortcut(Modifier.Ctrl|Modifier.Win, Key.NumPad9, async ()=>
		                                                                   {
			                                                                   // Console.Beep(300, 1000);
			                                                                   _ = Resolve<Trn_ArrangeWindows_Vivaldi>()
				                                                                   .ArrangeWindowsAsync();
		                                                                   });
		
		Keyboard.RegisterShortcut(Modifier.Ctrl|Modifier.Win, Key.NumPad8, async ()=>
		                                                                   {
			                                                                   // Console.Beep(300, 1000);
			                                                                   _ = Resolve<Trn_ArrangeWindows_Edge>()
				                                                                   .ArrangeWindowsAsync();
		                                                                   });
		
		return base.ExecuteAsync();
	}
}