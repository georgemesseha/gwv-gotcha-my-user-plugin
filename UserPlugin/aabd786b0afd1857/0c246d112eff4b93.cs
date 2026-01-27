
partial class _aabd786b0afd1857
{
    public async Task<int> _0c246d112eff4b93()
    {
        OpenDirectoryInVSCode("D:/");
       return 0; // return the output port index according to your logic
    }

    private void OpenDirectoryInVSCode(string directoryPath)
    {
        var dirPath = @"D:\Projects\gwv.Gotcha\gwv.Gotcha.Wpf\bin\Debug\net8.0-windows\__USER_PLUGIN__";
        System.Diagnostics.Process.Start("cmd.exe", "/c code \"" + dirPath + "\"");
    }
}
