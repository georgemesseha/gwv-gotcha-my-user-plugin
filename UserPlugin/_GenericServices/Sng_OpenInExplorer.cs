namespace UserPlugin._GenericServices;

public class Sng_OpenInExplorer : SingletonService
{
	public async Task OpenFolderAsync(string path)
	{
		await RunCommandAsFunctionAsync("explorer .", path, false, null, null);
	}
}