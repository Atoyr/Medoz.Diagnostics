namespace Medoz.Diagnostics;

using System.Diagnostics;


public static class ProcessRunner
{

    public static void RunAsync(string fileName, string? arguments, string? workingDirectory = null, IDictionary<string, string>? environmentVariable = null)
    {

    }

    public static void Run(string fileName, string? arguments )
    {
        ProcessStartInfo psi = new()
        {
            FileName = fileName,
            Arguments = arguments,
            UseShellExecute = false,
            CreateNoWindow = true,
            ErrorDialog = false,
            RedirectStandardError = true,
            RedirectStandardOutput = true,
        };

        Process p = new()
        {
            StartInfo = psi,
            EnableRaisingEvents = true,
        }
        
        p.OutputDataReceived += (sender, e) =>
        {

        };

        if (!process.Start())
        {
            throw new Exception("");
        }

        process.BeginOutputReadLine();
        process.BeginErrorReadLine();
    }


}
