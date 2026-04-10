namespace UserPlugin._GenericServices;

public class Sng_Docker : SingletonService
{
	public async Task ExportImageToTarAsync(string dstDir, string imageName)
	{
		var dt = DateTime.Now;
		var dstnFile = Path.Join(dstDir, $"{imageName}_{dt:yyyyMMdd_HHmmss}.tar");
		await RunCommandInTerminalAsync($"docker save {imageName} {dstnFile}", "C:\\");
	}
}