using System.Text.Json.Serialization;

namespace Sirius.formats;

using J = JsonPropertyNameAttribute;

public class CurseForge : IFormatTemplate
{
    public string FormatName { get; set; }
    public string FormatVendor { get; set; }
    public string FormatSupportAuthor { get; set; }
    public string CoreManifestFilePath { get; set; }
    public string PackFileFolderPath { get; set; }
    public string FormatSubfix { get; set; }
    public string[]? ExtendedFormatFilePathes { get; set; }

    public CurseForge()
    {
        FormatName = "CurseForge Format";
        FormatVendor = "CurseForge";
        FormatSupportAuthor = "ProjectHDS";
        CoreManifestFilePath = "manifest.json";
        PackFileFolderPath = "overrides";
        FormatSubfix = "zip";
        ExtendedFormatFilePathes = new[] {"modlist.html"};
    }
}

/// <summary>
/// CurseFormat core manifest construct.
/// </summary>
public class CurseManifest
{
    [J("minecraft")] public Minecraft Minecraft { get; set; }
    [J("manifestType")] public string ManifestType { get; set; }
    [J("manifestVersion")] public long ManifestVersion { get; set; }
    [J("name")] public string Name { get; set; }
    [J("version")] public string Version { get; set; }
    [J("author")] public string Author { get; set; }
    [J("files")] public CFile[] Files { get; set; }
    [J("overrides")] public string Overrides { get; set; }
}
public class CFile
{
    [J("projectID")] public long ProjectId { get; set; }
    [J("fileID")] public long FileId { get; set; }
    [J("required")] public bool FileRequired { get; set; }
}

public class Minecraft
{
    [J("version")] public string Version { get; set; }
    [J("modLoaders")] public ModLoader[] ModLoaders { get; set; }
}

public class ModLoader
{
    [J("id")] public string Id { get; set; }
    [J("primary")] public bool Primary { get; set; }
}
