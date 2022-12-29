using System.CommandLine;
using System.Text.Json;
using Serilog;

namespace Sirius;

class Program
{
    public static void Main(string[] args)
    {
        Log.Logger = new LoggerConfiguration().Enrich.FromLogContext().MinimumLevel.Information().WriteTo.Console().CreateLogger();

        var rootCommand = new RootCommand("Sirius!");
        var buildCommand = new Command("build", "build modpack to target format.");
        var testCommand = new Command("test", "test modpack");
        
    }

    private static SiriusConfig LoadConfig(string path)
    {
        var config = JsonSerializer.Deserialize<SiriusConfig>(File.ReadAllText(path));
        if (config is null)
        {
            Log.Logger.Error("Can't read config!");
            throw new FileNotFoundException("Can't read config");
        }
        return config;
    }
}
