using J = System.Text.Json.Serialization.JsonPropertyNameAttribute;

namespace Yoonir.Modrinth.Model;

public class ModrinthGetProjectRsp
{
    /// <summary>
    /// The slug of a project, used for vanity URLs.
    /// Regex: <code> ^[\w!@$()`.+,"\-']{3,64}$</code>
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
    /// A long form description of the project.
    /// </summary>
    [J("body")] public string? Body { get; set; }
    
    /// <summary>
    /// A list of categories which are searchable but non-primary.
    /// </summary>
    [J("additional_categories")] public List<object>? AdditionalCategories { get; set; }
    
    /// <summary>
    /// An optional link to where to submit bugs or issues with the project.
    /// </summary>
    [J("issues_url")] public Uri? IssuesUrl { get; set; }
    
    /// <summary>
    /// An optional link to the source code of the project.
    /// </summary>
    [J("source_url")] public Uri? SourceUrl { get; set; }
    
    /// <summary>
    /// An optional link to the project's wiki page or other relevant information.
    /// </summary>
    [J("wiki_url")] public Uri? WikiUrl { get; set; }
    
    /// <summary>
    /// An optional invite link to the project's discord.
    /// </summary>
    [J("discord_url")] public Uri? DiscordUrl { get; set; }
    
    /// <summary>
    /// A list of donation links for the project.
    /// </summary>
    [J("donation_urls")] public List<DonationUrl?>? DonationUrls { get; set; }
    
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
    [J("id")] public string? Id { get; set; }
    
    /// <summary>
    /// The ID of the team that has ownership of this project.
    /// </summary>
    [J("team")] public string? Team { get; set; }
    
    /// <summary>
    /// Default: <code>null</code>
    /// The link to the long description of the project (only present for old projects).
    /// </summary>
    [Obsolete("Deprecated")]
    [J("body_url")] public string? BodyUrl { get; set; }
    
    /// <summary>
    /// A message that a moderator sent regarding the project.
    /// </summary>
    [J("moderator_message")] public ModMessage? ModeratorMessage { get; set; }
    
    /// <summary>
    /// The date the project was published.
    /// </summary>
    [J("published")] public string? Published { get; set; }
    
    /// <summary>
    /// The date the project was last updated.
    /// </summary>
    [J("updated")] public string? Updated { get; set; }
    
    /// <summary>
    /// The date the project's status was set to approved or unlisted.
    /// </summary>
    [J("approved")] public string? Approved { get; set; }

    /// <summary>
    /// The total number of users following the project.
    /// </summary>
    [J("followers")] public int? Followers { get; set; }
    
    /// <summary>
    /// Enum: <code>"approved"</code> <code>"rejected"</code> <code>"draft"</code> <code>"unlisted"</code> <code>"archived"</code> <code>"processing"</code> <code>"unknown"</code>
    /// The status of the project.
    /// </summary>
    [J("status")] public string? Status { get; set; }
    
    /// <summary>
    /// The license of the project.
    /// </summary>
    [J("license")] public Lic? License { get; set; }
    
    /// <summary>
    /// A list of the version IDs of the project (will never be empty unless <code>draft</code> status).
    /// </summary>
    [J("versions")] public List<string?>? Versions { get; set; }
    
    /// <summary>
    /// A list of images that have been uploaded to the project's gallery.
    /// </summary>
    [J("gallery")] public List<Gallery?>? Galleries { get; set; }

    public class DonationUrl
    {
        /// <summary>
        /// The ID of the donation platform.
        /// </summary>
        [J("id")] public string? Id { get; set; }
        
        /// <summary>
        /// The donation platform this link is to.
        /// </summary>
        [J("platform")] public string? Platform { get; set; }
        
        /// <summary>
        /// The URL of the donation platform and user.
        /// </summary>
        [J("url")] public Uri? Url { get; set; }
    }
    
    public class ModMessage
    {
        /// <summary>
        /// The message that a moderator has left for the project.
        /// </summary>
        [J("message")] public string? Message { get; set; }
        
        /// <summary>
        /// The longer body of the message that a moderator has left for the project.   
        /// </summary>
        [J("body")] public string? Body { get; set; }
    }

    public class Lic
    {
        /// <summary>
        /// The license id of a project, retrieved from the licenses get route.
        /// </summary>
        [J("id")] public string? Id { get; set; }
        
        /// <summary>
        /// The long name of a license.
        /// </summary>
        [J("name")] public string? Name { get; set; }
        
        /// <summary>
        /// The URL to this license.
        /// </summary>
        [J("url")] public Uri? Url { get; set; }
    }
    
    public class Gallery
    {
        /// <summary>
        /// The URL of the gallery image.
        /// </summary>
        [J("url")] public Uri? Url { get; set; }
        
        /// <summary>
        /// Whether the image is featured in the gallery.
        /// </summary>
        [J("featured")] public bool Featured { get; set; }
        
        /// <summary>
        /// The title of the gallery image.
        /// </summary>
        [J("title")] public string? Title { get; set; }
        
        /// <summary>
        /// The description of the gallery image.
        /// </summary>
        [J("description")] public string? Description { get; set; }
        
        /// <summary>
        /// The date and time the gallery image was created.
        /// </summary>
        [J("created")] public string? Created { get; set; }
    }
}
