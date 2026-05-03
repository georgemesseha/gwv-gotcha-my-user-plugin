namespace UserPlugin._GenericServices;

public class Sng_OpenInExplorer : SingletonService
{
	public async Task OpenFolderAsync(string path)
	{
		await Integration.RunProcessAsync("explorer .", path, null, null);
	}
}