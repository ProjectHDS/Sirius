using System.Text.Json.Serialization;

namespace Sirius.formats;

using J = JsonPropertyNameAttribute;

public class MultiMC : IFormatTemplate
{
    public string FormatName { get; set; }
    public string FormatVendor { get; set; }
    public string FormatSupportAuthor { get; set; }
    public string CoreManifestFilePath { get; set; }
    public string PackFileFolderPath { get; set; }
    public string FormatSubfix { get; set; }
    public string[]? ExtendedFormatFilePathes { get; set; }

    public MultiMC()
    {
        FormatName = "MultiMC Format";
        FormatVendor = "MultiMC";
        FormatSupportAuthor = "ProjectHDS";
        CoreManifestFilePath = "instance.cfg";
        FormatSubfix = "zip";
        ExtendedFormatFilePathes = new[] {"mmc-pack.json", ".packignore"};
    }
}

/// <summary>
/// MMC Format core manifest construct.
/// </summary>
public class MMCPack
{
    [J("components")] public Component[] Component { get; set; }
    [J("formatVersion")] public int FormatVersion { get; set; }
}

public class Component
{
    [J("cachedName")] public string CachedName { get; set; }
    [J("cachedVersion")] public string CachedVersion { get; set; }
    [J("uid")] public string Uid { get; set; }
    [J("version")] public string Version { get; set; }
    [J("cachedVolatile")] public bool? CachedVolatile { get; set; }
    [J("dependencyOnly")] public bool? DependencyOnly { get; set; }
    [J("important")] public bool? Important { get; set; }
    [J("cachedRequires")] public CachedRequire[]? CachedRequires { get; set; }
}

public class CachedRequire
{
    [J("suggests")] public string Suggests { get; set; }
    [J("uid")] public string Uid { get; set; }
}
