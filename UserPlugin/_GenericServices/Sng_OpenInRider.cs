
namespace UserPlugin._GenericServices;

public class Sng_OpenInRider : SingletonService
{
	public async Task OpenSolutionAsync(string slnFilePath)
	{
		var file = new FileInfo(slnFilePath);
		if (file.Exists == false)
		{
			throw new
				InvalidOperationException($"File path [{slnFilePath}] provided to {this.GetType()}.{nameof(OpenSolutionAsync)} doesn't exist");
		}

		// await RunExternalAsync("notepad", "");
		
		
		//totest
		// await Run.Command.NonInteractiveAsync($"rider64 \"{slnFilePath}\"", 
		//                                           file.Directory!.FullName);
		await External.RunPowerShellAsync($"rider64 \"{slnFilePath}\"", 
		                                      file.Directory!.FullName);

	}

	public async Task OpenDirectoryAsync(string dirPath)
	{
		var directory = new DirectoryInfo(dirPath);
		if (directory.Exists == false)
		{
			throw new
				InvalidOperationException($"Directory path [{dirPath}] provided to {this.GetType()}.{nameof(OpenDirectoryAsync)} doesn't exist");
		}
		
		
		// await Run.Command.NonInteractiveAsync($"rider64 \"{dirPath}\"", 
		//                                           dirPath,
		//                                           null,
		//                                           null);
		
		//totest
		await External.RunPowerShellAsync($"rider64 \"{dirPath}\"", 
		                                      dirPath,
		                                      null,
		                                      null);
	}
	
	public async Task OpenFileAsync(string filePath)
	{
		var file = new FileInfo(filePath);
		if (file.Exists == false)
		{
			throw new
				InvalidOperationException($"File path [{filePath}] provided to {this.GetType()}.{nameof(OpenFileAsync)} doesn't exist");
		}
		
		//
		// await Run.Command.NonInteractiveAsync($"rider64 \"{file.FullName}\"", 
		//                                           file.DirectoryName,
		//                                           null,
		//                                           null);
		
		//totest
		await External.RunPowerShellAsync($"rider64 \"{file.FullName}\"", 
		                                      file.DirectoryName);
	}
}