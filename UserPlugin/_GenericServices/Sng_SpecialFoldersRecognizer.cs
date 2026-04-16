namespace UserPlugin._GenericServices;

public class Sng_SpecialFoldersRecognizer : SingletonService
{
	public string? OneDrivePath => Environment.GetEnvironmentVariable("OneDrive");

	
}