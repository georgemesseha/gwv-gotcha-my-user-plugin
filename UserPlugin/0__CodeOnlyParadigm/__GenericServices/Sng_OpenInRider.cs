
public class Sng_OpenInRider : SingletonService
{
	public override Task ExecuteAsync()
	{
		throw new NotImplementedException(); 
	}
	
	public async Task OpenSolutionAsync(string slnFilePath)
	{
		var file = new FileInfo(slnFilePath);
		if (file.Exists == false)
		{
			throw new
				InvalidOperationException($"File path [{slnFilePath}] provided to {this.GetType()}.{nameof(OpenSolutionAsync)} doesn't exist");
		}
		
		
		await Context.Integration.RunAsFunctionAsync($"rider \"{slnFilePath}\"", 
		                                             file.Directory!.FullName,
		                                             false,
		                                             null,
		                                             null);
	}

	public async Task OpenDirectory(string dirPath)
	{
		var directory = new DirectoryInfo(dirPath);
		if (directory.Exists == false)
		{
			throw new
				InvalidOperationException($"Directory path [{dirPath}] provided to {this.GetType()}.{nameof(OpenDirectory)} doesn't exist");
		}
		
		
		await Context.Integration.RunAsFunctionAsync($"rider \"{dirPath}\"", 
		                                             dirPath,
		                                             false,
		                                             null,
		                                             null);
	}
}