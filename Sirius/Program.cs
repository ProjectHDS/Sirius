using System.Text.Json;
using Serilog;

namespace Sirius;

class Program
{
    /// <summary>
    /// Sirius Entry.
    /// </summary>
    /// <param name="siriusConfigPath">Sirius configuration file absolute path.</param>
    /// <returns></returns>
    /// <exception cref="NullReferenceException"></exception>
    public static void Main(string siriusConfigPath = "./sirius.json")
    {
        Log.Logger = new LoggerConfiguration().Enrich.FromLogContext().MinimumLevel.Information().WriteTo.Console().CreateLogger();
        
        SiriusConfig config = LoadConfig(siriusConfigPath);

    }

    private static SiriusConfig? LoadConfig(string path)
    {
        var config = JsonSerializer.Deserialize(File.ReadAllText(path), SiriusConfigContext.Default.SiriusConfig);
        if (config is null)
        {
            Log.Logger.Error("Can't read config!");
            return null;
        }
        return config;
    }
}
