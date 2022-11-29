using J = System.Text.Json.Serialization.JsonPropertyNameAttribute;

namespace Yoonir.Modrinth.Model;

public class ModrinthGetProjectRsp
{
    [J("slug")] public string? Slug { get; set; }
    [J("title")] public string? Title { get; set; }
    [J("description")] public string? Description { get; set; }
    [J("categories")] public List<string?>? Categories { get; set; }
    [J("client_side")] public string? ClientSide { get; set; }
    [J("server_side")] public string? ServerSide { get; set; }
    [J("body")] public string? Body { get; set; }
    [J("additional_categories")] public List<object>? AdditionalCategories { get; set; }
    [J("issues_url")] public Uri? IssuesUrl { get; set; }
    [J("source_url")] public Uri? SourceUrl { get; set; }
    [J("wiki_url")] public Uri? WikiUrl { get; set; }
    [J("discord_url")] public Uri? DiscordUrl { get; set; }
    [J("donation_urls")] public List<DonationUrl?>? DonationUrls { get; set; }
    [J("project_type")] public string? ProjectType { get; set; }
    [J("downloads")] public long Downloads { get; set; }
    [J("icon_url")] public Uri? IconUrl { get; set; }
    [J("id")] public string? Id { get; set; }
    [J("team")] public string? Team { get; set; }
    [J("body_url")] public object? BodyUrl { get; set; }
    [J("moderator_message")] public object? ModeratorMessage { get; set; }
    [J("published")] public string? Published { get; set; }
    [J("updated")] public string? Updated { get; set; }
    [J("approved")] public string? Approved { get; set; }
    [J("followers")] public long Followers { get; set; }
    [J("status")] public string? Status { get; set; }
    [J("license")] public Lic? License { get; set; }
    [J("versions")] public List<string?>? Versions { get; set; }
    [J("gallery")] public List<Gallery?>? Galleries { get; set; }

    public class DonationUrl
    {
        [J("id")] public string? Id { get; set; }
        [J("platform")] public string? Platform { get; set; }
        [J("url")] public Uri? Url { get; set; }
    }

    public class Gallery
    {
        [J("url")] public Uri? Url { get; set; }
        [J("featured")] public bool Featured { get; set; }
        [J("title")] public string? Title { get; set; }
        [J("description")] public string? Description { get; set; }
        [J("created")] public string? Created { get; set; }
    }

    public class Lic
    {
        [J("id")] public string? Id { get; set; }
        [J("name")] public string? Name { get; set; }
        [J("url")] public Uri? Url { get; set; }
    }
}