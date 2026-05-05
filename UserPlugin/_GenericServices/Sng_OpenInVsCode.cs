
namespace UserPlugin._GenericServices;

public class Sng_OpenInVsCode : SingletonService
{
	protected override Task ExecuteAsync()
	{
		throw new NotImplementedException(); 
	}
	
	public async Task OpenDirectoryAsync(string dirPath)
	{
		var directory = new DirectoryInfo(dirPath);
		if (directory.Exists == false)
		{
			throw new
				InvalidOperationException($"Directory path [{dirPath}] provided to {this.GetType()}.{nameof(OpenDirectoryAsync)} doesn't exist");
		}
		
		
		// await this.Run.Command.NonInteractiveAsync($"code \"{dirPath}\"", 
		//                                            dirPath,
		//                                            null,
		//                                            null); 
		
		await this.Run.Command.NonInteractiveAsync($"code \"{dirPath}\"", 
		                                           dirPath); 
		
		//
		// await Run.Command.NonInteractiveAsync($"code \"{dirPath}\"", 
		//                                           dirPath,
		//                                           null,
		//                                           null);
	}
}