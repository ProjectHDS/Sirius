using J = System.Text.Json.Serialization.JsonPropertyNameAttribute;

namespace Yoonir.Modrinth.Model;

public class ModrinthSearchResultRsp
{
    /// <summary>
    /// The list of results.
    /// </summary>
    [J("hits")] public List<Hit?>? Hits { get; set; }
    
    /// <summary>
    /// The number of results that were skipped by the query.
    /// </summary>
    [J("offset")] public int? Offset { get; set; }
    
    /// <summary>
    /// The number of results that were returned by the query.
    /// </summary>
    [J("limit")] public int? Limit { get; set; }
    
    /// <summary>
    /// The total number of results that match the query.
    /// </summary>
    [J("total_hits")] public int? TotalHits { get; set; }
    public class Hit
    {
        /// <summary>
        /// The slug of a project, used for vanity URLs.
        /// Regex: <code>^[\w!@$()`.+,"\-']{3,64}$</code>
        /// </summary>
        [J("slug")] public string? Slug { get; set; }
        
        /// <summary>
        /// The title or name of the project.
        /// </summary>
        [J("title")] public string? Title { get; set; }
        
        /// <summary>
        /// A short description of the project.
        /// </summary>
        [J("description")] public string? Description { get; set; }
        
        /// <summary>
        /// A list of the categories that the project has.
        /// </summary>
        [J("categories")] public List<string?>? Categories { get; set; }
        
        /// <summary>
        /// Enum: <code>"required"</code> <code>"optional"</code> <code>"unsupported"</code>
        /// The client side support of the project.
        /// </summary>
        [J("client_side")] public string? ClientSide { get; set; }
    
        /// <summary>
        /// Enum: <code>"required"</code> <code>"optional"</code> <code>"unsupported"</code>
        /// The server side support of the project.
        /// </summary>
        [J("server_side")] public string? ServerSide { get; set; }
        
        /// <summary>
        /// Enum: <code>"mod"</code> <code>"modpack"</code> <code>"resourcepack"</code>
        /// The project type of the project.
        /// </summary>
        [J("project_type")] public string? ProjectType { get; set; }
    
        /// <summary>
        /// The total number of downloads of the project.
        /// </summary>
        [J("downloads")] public int? Downloads { get; set; }
    
        /// <summary>
        /// The URL of the project's icon.
        /// </summary>
        [J("icon_url")] public Uri? IconUrl { get; set; }
        
        /// <summary>
        /// The ID of the project, encoded as a base62 string.
        /// </summary>
        [J("project_id")] public string? ProjectId { get; set; }
        
        /// <summary>
        /// The username of the project's author.
        /// </summary>
        [J("author")] public string? Author { get; set; }
        
        /// <summary>
        /// A list of the categories that the project has which are not secondary.
        /// </summary>
        [J("display_categories")] public List<string?>? DisplayCategories { get; set; }
        
        /// <summary>
        /// A list of the minecraft versions supported by the project.
        /// </summary>
        [J("versions")] public List<string?>? Versions { get; set; }
        
        /// <summary>
        /// The total number of users following the project.
        /// </summary>
        [J("follows")] public int? Follows { get; set; }
        
        /// <summary>
        /// The date the project was added to search.
        /// </summary>
        [J("date_created")] public string? DateCreated { get; set; }
        
        /// <summary>
        /// The date the project was last modified.
        /// </summary>
        [J("date_modified")] public string? DateModified { get; set; }
        
        /// <summary>
        /// The latest version of minecraft that this project supports.
        /// </summary>
        [J("latest_version")] public string? LatestVersion { get; set; }
        
        /// <summary>
        /// The license of the project.
        /// </summary>
        [J("license")] public string? License { get; set; }
        
        /// <summary>
        /// All gallery images attached to the project.
        /// </summary>
        [J("gallery")] public List<string?>? Gallery { get; set; }
    }
}

