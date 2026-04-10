using System.Data;
using System.Net;
using Gwv.Gotcha.Services.VideoSplitting;

namespace UserPlugin._GenericServices;

using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;




public class Sng_VideoEditor : SingletonService
{
	// private readonly ISng_FileIO _sngFileIo;
	// private readonly ISng_ProcessRunner _sngProcessRunner;
	// private readonly ISng_Clipboard _sngClipboard;

	private void _OpenDirInVSCode(string dirPath)
	{
		try
		{
			var psi = new ProcessStartInfo
			{
				FileName = "code",
				Arguments = ".",
				UseShellExecute = true,
				WorkingDirectory = dirPath
			};
			Process.Start(psi);
		}
		catch (Exception e)
		{
			ReportErrorAsync(e.ToString());
			SpeakAsync("Couldn't start the workshop directory in VS Code.");
		}
	}
	
	private async Task<string> _CreateWorkshopFor(string filePath)
	{
		var srcFile = new FileInfo(filePath);
		var extension = srcFile.Extension;
		
		var timestamp = DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss");
		var workshopName = $"wsh_{timestamp}";
		var workshopDir = srcFile.Directory!.CreateSubdirectory(workshopName);
		
		var workshopFilePath = Path.Combine(workshopDir.FullName, $"src{extension}");
		srcFile.MoveTo(workshopFilePath);

		workshopDir.CreateSubdirectory("gain");
		// string instructionsFilePath = Path.Combine(workshopDir.FullName, "instructions.csv");
		// string instructionsContent = "Start,End";
		// await File.WriteAllTextAsync(instructionsFilePath, instructionsContent);
		

		// string execFileContent = """
		//                          @echo off
		//                          setlocal enabledelayedexpansion
		//                          
		//                          set "url=http://127.0.0.1:<PORT>/exec-video-splitting-workshop"
		//                          
		//                          set "dir=%cd%"
		//                          set "escapedDir=%dir:\=\\%"
		//                          
		//                          set "json={\"workshopDir\":\"!escapedDir!\"}"
		//                          
		//                          echo Sending request...
		//                          curl -X POST ^
		//                            -H "Content-Type: application/json" ^
		//                            -d "!json!" ^
		//                            "%url%"
		//                          
		//                          echo.
		//                          echo --- DONE ---
		//                          pause
		//                          
		//                          """;
		// execFileContent = execFileContent.Replace("<PORT>", _sngConstants.PORT_Gotcha_AspNetServer.ToString());
		// await File.WriteAllTextAsync(Path.Combine(workshopDir.FullName, "exec.bat"), execFileContent);
		//
		//
		// _sngClipboard.SetText(workshopDir.FullName);

		await this.AddCodeSnippetAsync("Workshop Directory", workshopDir.FullName);
		_ = SpeakAsync($"The workshop directory has been created!");
		
		// try
		// {
		// 	var psi = new ProcessStartInfo
		// 	{
		// 		FileName = "code",
		// 		Arguments = ".",
		// 		UseShellExecute = true,
		// 		WorkingDirectory = workshopDir.FullName
		// 	};
		// 	Process.Start(psi);
		// }
		// catch (Exception e)
		// {
		// 	_ = _sngTextToSpeech.Speak("Couldn't start the workshop directory in VS Code.");
		// }
		

		return workshopDir.FullName;
	}
	
	// public async Task<ISng_VideoEditor.StartSplittingSessionStatus> PrepareWorkshop(string workshopDir, string srcVideoFile)
	// {
	// 	if(srcVideoFile.StartsWith("\"") && srcVideoFile.EndsWith("\"")) srcVideoFile = srcVideoFile.Substring(1, srcVideoFile.Length - 2); // Remove quotes ( "C:\Users\user\Downloads\video.mp4")"))
	// 	
	// 	if (Directory.Exists(workshopDir) == false)
	// 		return ISng_VideoEditor.StartSplittingSessionStatus.Error_InvalidWorkshopDirPath;
	//
	// 	if (File.Exists(srcVideoFile) == false)
	// 		return ISng_VideoEditor.StartSplittingSessionStatus.Error_InvalidSourceVideoFilePath;
	//
	// 	var extension = Path.GetExtension(srcVideoFile);
	// 	var subWorkshopPath = Path.Combine(workshopDir, $"split  {DateTime.Now:yyyy-MM-dd  HH_mm_ss}{extension}");
	// 	Directory.CreateDirectory(subWorkshopPath);
	// 	
	// 	var instructionsFilePath = Path.Combine(subWorkshopPath, "instructions.csv").Replace("\\", "/");
	// 	var videoFilePath = Path.Combine(subWorkshopPath, $"source{extension}").Replace("\\", "/");
	// 	await File.WriteAllTextAsync(instructionsFilePath, $"{videoFilePath}\n0:0:0,0:0:5");
	// 	
	// 	_OpenDirInVSCode(subWorkshopPath);
	// 	
	// 	File.Move(srcVideoFile, videoFilePath);
	// 	return ISng_VideoEditor.StartSplittingSessionStatus.Success_Started;
	// }
	//

	private async Task<string> _CreateWorkshopForFilePathOnClipboardAsync()
	{
		var filePath = Clipboard.GetText();
		if (string.IsNullOrWhiteSpace(filePath))
		{
			var msg = "The text on the clipboard is not a valid file path.";
			_ = SpeakAsync(msg);
			throw new Exception(msg);
			
		}
		
		if(filePath.StartsWith("\"") && filePath.EndsWith("\"")) filePath = filePath[1..^1]; // remove quotes ( "C:\Users\user\Videos\video.mp4" => C:\Users\user\Videos\video.mp4))
		
		if (File.Exists(filePath) == false)
		{
			var msg = "The text on the clipboard is not a valid file path.";
			_ = SpeakAsync(msg);
			throw new Exception(msg);
		}

		string[] possibleVideoFileExtensions = [".mp4", ".mkv", ".asf", "webm", ".wmv", ".m4v", ".avi", ".mov"];
		if (possibleVideoFileExtensions.Any(ext => filePath.EndsWith(ext, StringComparison.OrdinalIgnoreCase)) == false)
		{
			var msg = "The extension of the file path on the clipboard is not of a video file.";
			_ = SpeakAsync(msg);
			throw new Exception(msg);
		}

		var workshopPath = await _CreateWorkshopFor(filePath);
		return workshopPath;
	}
	
	private  (bool success, List<(string startTime, string endTime)> spans) _ParseInstructions(string instructions)
	{
		instructions = Regex.Replace(instructions.Trim(), "\n+", "\n"); // Remove multiple newlines ( \n\n)
		var lines = instructions.Trim().Split("\n");
		if (lines.Length < 1)
		{
			_ = SpeakAsync("Empty splitting instructions");
			return (false, new List<(string startTime, string endTime)>());
			
		}
		
		var timeRanges = new List<(string startTime, string endTime)>(); // <string, string>()
		for (var x = 0; x < lines.Length; x++)
		{
			var line = lines[x].Trim();
			if(string.IsNullOrWhiteSpace(line)) continue;
			var timeRangeParts = line.Split(",");
			if(timeRangeParts.Length != 2) throw new Exception("Invalid time range");
			var startTime = timeRangeParts[0].Trim();
			var endTime = timeRangeParts[1].Trim();
			timeRanges.Add((startTime, endTime));
		}
		return (true, timeRanges);
	}

	private (bool success, string path) _FindSrcFilePath(string workshopDirPath)
	{
		var files = Directory.GetFiles(workshopDirPath, "src.*", SearchOption.TopDirectoryOnly);
		if (files.Length == 0)
		{
			_ = SpeakAsync("Couldn't find the source file.");
			return (false, string.Empty);
		}

		if (files.Length > 1)
		{
			_ = SpeakAsync("Error: More than one file named as src. something found.");
			return (false, string.Empty);
		}
		
		return (true, files[0]);
	}
	
	private async Task _RunVideoSplittingInstructionsAsync(string workshopPath, string instructions)
	{
		string instructionsFilePath = Path.Combine(workshopPath, "instructions.csv").Replace("\\", "/");
		// var instructions = await File.ReadAllTextAsync(instructionsFilePath);
		
		var findingSrcResult = _FindSrcFilePath(workshopPath);
		if(findingSrcResult.success == false) return;
		
		var srcFilePath = findingSrcResult.path;
		
		var spansResult = _ParseInstructions(instructions);
		if(spansResult.success == false) return;
		
		
		await _RunVideoSplittingInstructionsAsync(workshopPath, srcFilePath, spansResult.spans);
	}
	
	public async Task SplitVideoWhosePathOnClipboardAsync()
	{
		var workshopPath = await this._CreateWorkshopForFilePathOnClipboardAsync();
		var instructions = await this.RequestStringAsync("Write time periods each in a separate line in format 0:0:0, 0:0:5 ");
		await this._RunVideoSplittingInstructionsAsync(workshopPath, instructions);
	}
	
	private async Task _RunVideoSplittingInstructionsAsync(string workshopPath, 
	                                                       string srcFilePath,
		                                                   List<(string startTime, string endTime)> spans)
	{
		var destinationDir = Path.Combine(workshopPath, "gain").Replace("\\", "/");
		if(Directory.Exists(destinationDir) == false) Directory.CreateDirectory(destinationDir); // Create the destination directory if it doesn't exist ( ffmpeg will create it automatically if it doesn't exist

		StringBuilder commands = new();
		
		int partNumber = 0;
        foreach (var parts in spans)
        {
            var startTime = parts.startTime;
            var endTime = parts.endTime;
            partNumber++;

            // var clipName =
            //     $"{DateTimeOffset.UtcNow.ToUnixTimeMilliseconds()}__{RandomNumber()}";

            var output =
                Path.Combine(destinationDir, $"{partNumber}.mp4").Replace("\\", "/");
			     var powershellCommand = $@"& ffmpeg -ss '{startTime}' -to '{endTime}' -i '{srcFilePath}' -c copy '{output}'; ";
			     commands.Append(powershellCommand);
        }

        commands.Append("Add-Type -AssemblyName System.Speech; (New-Object System.Speech.Synthesis.SpeechSynthesizer).Speak('Done splitting all!');");

        await this.AddCodeSnippetAsync("Commands going to run", commands.ToString());
        await this.AddCodeSnippetAsync("Gain dir", destinationDir);
		Clipboard.SetText(destinationDir);
        
        _ = SpeakAsync("Dismiss on completion. And find gain directory on clipboard.");
        
        await this.RunCommandInTerminalAsync(commands.ToString(), 
                                              workshopPath);
    }
	
	private async Task _RepairVideosInDirectoryAsync(string dirPath)
	{
		if (Directory.Exists(dirPath) == false)
		{
			_ = SpeakAsync("Invalid directory path.");
			return;
		}

		var videoExtensions = new[]
		{
			"*.mp4", "*.mkv", "*.avi", "*.mov", "*.wmv", "*.flv", "*.webm", "*.mpeg", "*.mpg", "*.m4v"
		};

		var filePaths = videoExtensions
		                .SelectMany(ext => Directory.GetFiles(dirPath, ext))
		                .ToArray();

		if (filePaths.Length == 0)
		{
			_ = SpeakAsync("No supported files found in that directory.");
			return;
		}
		
		var repairedFolderPath = Path.Combine(dirPath, "__repaired");
		if(Directory.Exists(repairedFolderPath) == false) Directory.CreateDirectory(repairedFolderPath);
		
		StringBuilder commands = new();


		int fileNo = 0;
		foreach (var filePath in filePaths)
		{
			fileNo++;
			var dstFilePath = Path.Combine(repairedFolderPath, Path.GetFileName(filePath));
			var powershellCommand = $@"& ffmpeg -ss 00:00:00 -to 24:00:00 -i """"{filePath}"""" -c:v libx264 -preset fast -crf 18 -c:a aac -b:a 192k """"{dstFilePath}""""; ";
			commands.Append(powershellCommand);
			commands.Append("Add-Type -AssemblyName System.Speech; (New-Object System.Speech.Synthesis.SpeechSynthesizer).Speak('Done repairing all!');");
			Clipboard.SetText($"File {fileNo} has been repaired.");
		}
        
		_ = SpeakAsync("It could be a lengthy operation. Dismiss on completion. And find gain directory on clipboard.");
		Clipboard.SetText(repairedFolderPath);
		
		await RunCommandInTerminalAsync(commands.ToString(), 
			                                      dirPath);
	}

	public async Task RepairVideosInDirectoryOnClipboardAsync()
	{
		var dirPath = Clipboard.GetText();
		if (Directory.Exists(dirPath) == false)
		{
			_ = SpeakAsync("The text on clipboard is not a valid directory path.");
			return;
		}
		await _RepairVideosInDirectoryAsync(dirPath);
	}

}