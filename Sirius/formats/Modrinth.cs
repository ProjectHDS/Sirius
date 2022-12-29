using System.Text.Json.Serialization;

namespace Sirius.formats;

using J = JsonPropertyNameAttribute;

public class Modrinth : IFormatTemplate
{
    public string FormatName { get; set; }
    public string FormatVendor { get; set; }
    public string FormatSupportAuthor { get; set; }
    public string CoreManifestFilePath { get; set; }
    public string PackFileFolderPath { get; set; }
    public string FormatSubfix { get; set; }
    public string[]? ExtendedFormatFilePathes { get; set; }

    public Modrinth()
    {
        FormatName = "Modrinth Format";
        FormatVendor = "Modrinth";
        FormatSupportAuthor = "ProjectHDS";
        CoreManifestFilePath = "modrinth.index.json";
        PackFileFolderPath = "overrides";
        FormatSubfix = "mrpack";
        ExtendedFormatFilePathes = null;
    }
}

/// <summary>
/// Modrinth Format core manifest construct.
/// </summary>
public class ModrinthManifest
{
    [J("formatVersion")] public string FormatVersion { get; set; }
    [J("game")] public string Game { get; set; }
    [J("versionId")] public string VersionId { get; set; }
    [J("name")] public string Name { get; set; }
    [J("summary")] public string? Summary { get; set; }
    [J("files")] public MFile[] Files { get; set; }
    [J("dependencies")] public Dependencies Dependencies { get; set; }
}

public class MFile
{
    [J("path")] public string Path { get; set; }
    [J("hashes")] public Hashes Hashes { get; set; }
    [J("env")] public Env? Env { get; set; }
    [J("downloads")] public string[] Downloads { get; set; }
    [J("fileSize")] public int FileSize { get; set; }
}

public class Hashes
{
    [J("sha1")] public string Sha1 { get; set; }
    [J("sha512")] public string Sha512 { get; set; }
}

public class Env
{
    [J("client")] public string Client { get; set; }
    [J("server")] public string Server { get; set; }
}

public class Dependencies
{
    [J("minecraft")] public string? Minecraft { get; set; }
    [J("forge")] public string? Forge { get; set; }
    [J("fabric-loader")] public string? FabricLoader { get; set; }
    [J("quilt-loader")] public string? QuiltLoader { get; set; }
}
