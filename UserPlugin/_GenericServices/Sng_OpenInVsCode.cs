
namespace UserPlugin._GenericServices;

public class Sng_OpenInVsCode : SingletonService
{
	public override Task ExecuteAsync()
	{
		throw new NotImplementedException(); 
	}
	
	public async Task OpenDirectory(string dirPath)
	{
		var directory = new DirectoryInfo(dirPath);
		if (directory.Exists == false)
		{
			throw new
				InvalidOperationException($"Directory path [{dirPath}] provided to {this.GetType()}.{nameof(OpenDirectory)} doesn't exist");
		}
		
		
		await RunCommandAsFunctionAsync($"code \"{dirPath}\"", 
		                                             dirPath,
		                                             false,
		                                             null,
		                                             null);
	}
}