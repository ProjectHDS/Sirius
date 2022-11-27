namespace Sirius.formats;

/// <summary>
/// Template of all format supports.
/// </summary>
public interface IFormatTemplate
{
    /// <summary>
    /// Name of the format.
    /// </summary>
    public string FormatName { get; set; }

    /// <summary>
    /// Format vendor, explicitly the people/org who created the format.
    /// </summary>
    public string FormatVendor { get; set; }

    /// <summary>
    /// Author of the format support code in Sirius.
    /// </summary>
    public string FormatSupportAuthor { get; set; }

    /// <summary>
    /// The core manifest file path, that is, the files that store the most important and core information.
    /// For example, manifest.json is the file to reference here in CurseForge format, modrinth.index.json in Modrinth format.
    /// </summary>
    public string CoreManifestFilePath { get; set; }

    /// <summary>
    /// The Minecraft folder path, usually called .minecraft/minecraft in your launcher instance folder.
    /// This MUST be filled, due to multi-architecture support requirements.
    /// </summary>
    public string PackFileFolderPath { get; set; }

    /// <summary>
    /// Pack file subfix, like zip in CurseForge format, mrpack in Modrinth format.
    /// </summary>
    public string FormatSubfix { get; set; }

    /// <summary>
    /// Optional, other format specific files that form the format with the core manifest file together.
    /// modlist.html in CurseForge format, for example.
    /// Leave null when not available.
    /// </summary>
    public string[]? ExtendedFormatFilePathes { get; set; }
}
