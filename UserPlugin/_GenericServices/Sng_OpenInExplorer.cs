namespace UserPlugin._GenericServices;

public class Sng_OpenInExplorer : SingletonService
{
	public async Task OpenFolderAsync(string path)
	{
		await Run.Command.NonInteractiveAsync("explorer .", path, null, null);
	}
}