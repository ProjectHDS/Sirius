using J = System.Text.Json.Serialization.JsonPropertyNameAttribute;

namespace Yoonir.Modrinth.Model;

public class ModrinthGetProjAllDependsRsp
{
    /// <summary>
    /// Projects that the project depends upon.
    /// </summary>
    [J("projects")] public List<ModrinthGetProjectRsp?>? Projects { get; set; }

    /// <summary>
    /// Versions that the project depends upon.
    /// </summary>
    [J("versions")] public List<ProjectVersion?>? Versions { get; set; }

    public class ProjectVersion
    {
        /// <summary>
        /// The name of this version.
        /// </summary>
        [J("name")] public string? Name { get; set; }
        
        /// <summary>
        /// The version number. Ideally will follow semantic versioning.
        /// </summary>
        [J("version_number")] public string? VersionNumber { get; set; }
        
        /// <summary>
        /// The changelog for this version.
        /// </summary>
        [J("changelog")] public string? Changelog { get; set; }
        
        /// <summary>
        /// A list of specific versions of projects that this version depends on.
        /// </summary>
        [J("dependencies")] public List<Dependent?>? Dependencies { get; set; }
        
        /// <summary>
        /// A list of versions of Minecraft that this version supports.
        /// </summary>
        [J("game_versions")] public List<string?>? GameVersions { get; set; }
        
        /// <summary>
        /// Enum: <code>"release"</code> <code>"beta"</code> <code>"alpha"</code>
        /// The release channel for this version.
        /// </summary>
        [J("version_type")] public string? VersionType { get; set; }
        
        /// <summary>
        /// The mod loaders that this version supports.
        /// </summary>
        [J("loaders")] public List<string?>? Loaders { get; set; }
        
        /// <summary>
        /// Whether the version is featured or not.
        /// </summary>
        [J("featured")] public bool? Featured { get; set; }
        
        /// <summary>
        /// The ID of the version, encoded as a base62 string.
        /// </summary>
        [J("id")] public string? Id { get; set; }
        
        /// <summary>
        /// The ID of the project this version is for.
        /// </summary>
        [J("project_id")] public string? ProjectId { get; set; }
        
        /// <summary>
        /// The ID of the author who published this version.
        /// </summary>
        [J("author_id")] public string? AuthorId { get; set; }
        
        /// <summary>
        /// No info provided.
        /// </summary>
        [J("date_published")] public string? DatePublished { get; set; }
        
        /// <summary>
        /// The number of times this version has been downloaded.
        /// </summary>
        [J("downloads")] public int? Downlaods { get; set; }

        /// <summary>
        /// A link to the changelog for this version.
        /// </summary>
        [Obsolete("Deprecated")]
        [J("changelog_url")] public string? ChangelogUrl { get; set; }
        
        /// <summary>
        /// A list of files available for download for this version.
        /// </summary>
        [J("files")] public List<ModrinthFile?>? Files { get; set; }
    }
    
    public class Dependent
    {
        /// <summary>
        /// The ID of the version that this version depends on.
        /// </summary>
        [J("version_id")] public string? VersionId { get; set; }
        
        /// <summary>
        /// The ID of the project that this version depends on.
        /// </summary>
        [J("project_id")] public string? ProjectId { get; set; }
        
        /// <summary>
        /// The file name of the dependency, mostly used for showing external dependencies on modpacks.
        /// </summary>
        [J("file_name")] public string? FileName { get; set; }
        
        /// <summary>
        /// Enum: <code>"required"</code> <code>"optional"</code> <code>"incompatible"</code> <code>"embedded"</code>.
        /// The type of dependency that this version has.
        /// </summary>
        [J("dependency_type")] public string? DependencType { get; set; }
    }

    public class ModrinthFile
    {
        /// <summary>
        /// A map of hashes of the file. The key is the hashing algorithm and the value is the string version of the hash.
        /// </summary>
        [J("hashes")] public ModrinthFileHashes? Hashes { get; set; }
        
        /// <summary>
        /// A direct link to the file.
        /// </summary>
        [J("url")] public string? Url { get; set; }
        
        /// <summary>
        /// The name of the file.
        /// </summary>
        [J("filename")] public string? FileName { get; set; }
        
        /// <summary>
        /// No info provided.
        /// </summary>
        [J("primary")] public bool? Primary { get; set; }
        
        /// <summary>
        /// The size of the file in bytes.
        /// </summary>
        [J("size")] public int? Size { get; set; }
    }
    
    public class ModrinthFileHashes
    {
        [J("sha512")] public string? Sha512 { get; set; }
        [J("sha1")] public string? Sha1 { get; set; }
    }
}