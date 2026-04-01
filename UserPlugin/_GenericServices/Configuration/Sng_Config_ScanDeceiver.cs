namespace UserPlugin._GenericServices.Configuration;

public class Sng_Config_ScanDeceiver : SingletonService
{
	public string ProjectDir => @"D:\Projects\AspNetCore.Security.Client";
	
	public string SolutionFilePath => Path.Join(ProjectDir,  "AspNetClient.ContentSecurityPolicy.sln");
}