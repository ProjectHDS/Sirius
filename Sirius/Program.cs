using System.CommandLine;
using System.CommandLine.Builder;
using System.CommandLine.Parsing;
using System.Text.Json;
using LibGit2Sharp;
using Serilog;

namespace Sirius;

class Program
{
    private static SiriusConfig? Config { get; set; }
    private static string ConfigPath { get; set; } = "./sirius.json";
    public static string? CurrentVersion { get; set; }

    public static void Main(string[] args)
    {
        Log.Logger = new LoggerConfiguration().Enrich.FromLogContext().MinimumLevel.Information().WriteTo.Console().CreateLogger();

        var rootCommand = new RootCommand("Sirius!");
        // define commands
        var buildCommand = new Command("build", "build modpack to target format.");
        var testCommand = new Command("test", "test modpack");
        // apply commands
        rootCommand.Add(buildCommand);
        rootCommand.Add(testCommand);
        var commandLineBuilder = new CommandLineBuilder(rootCommand);
        commandLineBuilder.AddMiddleware(async (context, next) =>
        {
            var index = context.ParseResult.UnmatchedTokens.ToList().FindIndex(s=>s=="--config");
            if (index!=-1)
            {
                ConfigPath = context.ParseResult.UnmatchedTokens[index+1];
            }
            Config = LoadConfig(ConfigPath);
            PreCheck(Config.RootAbsolutePath!);
            await next(context);
        });
        var parser = commandLineBuilder.Build();
        // invoke commands
        parser.Invoke(args);
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

    private static void PreCheck(string path)
    {
        var repo = new Repository(Path.GetFullPath(path));
        Log.Logger.Information($"Commit: {repo.Head.Tip.Sha}[{repo.Head.Tip.Sha[..7]}]");
        var tags = string.Join(", ", repo.Tags.Where(tag => tag.Target == repo.Head.Tip).Select(t => t.FriendlyName));
        if (string.IsNullOrEmpty(tags))
        {
            Log.Logger.Information($"Tag(s): Not found");
            Log.Logger.Information($"Pack version: {repo.Head.FriendlyName}-{repo.Head.Tip.Sha[..7]}");
            CurrentVersion = $"{repo.Head.FriendlyName}-{repo.Head.Tip.Sha[..7]}-{Environment.GetEnvironmentVariable("GITHUB_RUN_NUMBER")??"none"}";
        }
        else
        {
            Log.Logger.Information($"Tag(s): {tags}");
            Log.Logger.Information($"Pack version: {tags}");
            CurrentVersion = tags;
        }
    }
}
