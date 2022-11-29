using J = System.Text.Json.Serialization.JsonPropertyNameAttribute;

namespace Yoonir.Curseforge.Model;

public class CurseforgeGetModRsp
{
    [J("data")] public Data? Rsp { get; set; }

    public class Data
    {
        [J("id")] public long Id { get; set; }
        [J("gameId")] public long GameId { get; set; }
        [J("name")] public string? Name { get; set; }
        [J("slug")] public string? Slug { get; set; }
        [J("links")] public Links? Links { get; set; }
        [J("summary")] public string? Summary { get; set; }
        [J("status")] public long Status { get; set; }
        [J("downloadCount")] public long DownloadCount { get; set; }
        [J("isFeatured")] public bool IsFeatured { get; set; }
        [J("primaryCategoryId")] public long PrimaryCategoryId { get; set; }
        [J("categories")] public List<Category>? Categories { get; set; }
        [J("classId")] public long ClassId { get; set; }
        [J("authors")] public List<Author>? Authors { get; set; }
        [J("logo")] public Logo? Logo { get; set; }
        [J("screenshots")] public List<Logo>? Screenshots { get; set; }
        [J("mainFileId")] public long MainFileId { get; set; }
        [J("latestFiles")] public List<LatestFile>? LatestFiles { get; set; }
        [J("latestFilesIndexes")] public List<LatestFilesIndex>? LatestFilesIndexes { get; set; }
        [J("dateCreated")] public DateTimeOffset DateCreated { get; set; }
        [J("dateModified")] public DateTimeOffset DateModified { get; set; }
        [J("dateReleased")] public DateTimeOffset DateReleased { get; set; }
        [J("allowModDistribution")] public bool AllowModDistribution { get; set; }
        [J("gamePopularityRank")] public long GamePopularityRank { get; set; }
        [J("isAvailable")] public bool IsAvailable { get; set; }
        [J("thumbsUpCount")] public long ThumbsUpCount { get; set; }
    }

    public class Author
    {
        [J("id")] public long Id { get; set; }
        [J("name")] public string? Name { get; set; }
        [J("url")] public string? Url { get; set; }
    }

    public class Category
    {
        [J("id")] public long Id { get; set; }
        [J("gameId")] public long GameId { get; set; }
        [J("name")] public string? Name { get; set; }
        [J("slug")] public string? Slug { get; set; }
        [J("url")] public string? Url { get; set; }
        [J("iconUrl")] public string? IconUrl { get; set; }
        [J("dateModified")] public DateTimeOffset DateModified { get; set; }
        [J("isClass")] public bool IsClass { get; set; }
        [J("classId")] public long ClassId { get; set; }
        [J("parentCategoryId")] public long ParentCategoryId { get; set; }
        [J("displayIndex")] public long DisplayIndex { get; set; }
    }

    public class LatestFile
    {
        [J("id")] public long Id { get; set; }
        [J("gameId")] public long GameId { get; set; }
        [J("modId")] public long ModId { get; set; }
        [J("isAvailable")] public bool IsAvailable { get; set; }
        [J("displayName")] public string? DisplayName { get; set; }
        [J("fileName")] public string? FileName { get; set; }
        [J("releaseType")] public long ReleaseType { get; set; }
        [J("fileStatus")] public long FileStatus { get; set; }
        [J("hashes")] public List<Hash>? Hashes { get; set; }
        [J("fileDate")] public DateTimeOffset FileDate { get; set; }
        [J("fileLength")] public long FileLength { get; set; }
        [J("downloadCount")] public long DownloadCount { get; set; }
        [J("downloadUrl")] public string? DownloadUrl { get; set; }
        [J("gameVersions")] public List<string>? GameVersions { get; set; }
        [J("sortableGameVersions")] public List<SortableGameVersion>? SortableGameVersions { get; set; }
        [J("dependencies")] public List<Dependency>? Dependencies { get; set; }
        [J("exposeAsAlternative")] public bool ExposeAsAlternative { get; set; }
        [J("parentProjectFileId")] public long ParentProjectFileId { get; set; }
        [J("alternateFileId")] public long AlternateFileId { get; set; }
        [J("isServerPack")] public bool IsServerPack { get; set; }
        [J("serverPackFileId")] public long ServerPackFileId { get; set; }
        [J("fileFingerprint")] public long FileFingerprint { get; set; }
        [J("modules")] public List<Module>? Modules { get; set; }
    }

    public class Dependency
    {
        [J("modId")] public long ModId { get; set; }
        [J("relationType")] public long RelationType { get; set; }
    }

    public class Hash
    {
        [J("value")] public string? Value { get; set; }
        [J("algo")] public long? Algo { get; set; }
    }

    public class Module
    {
        [J("name")] public string? Name { get; set; }
        [J("fingerprint")] public long Fingerprint { get; set; }
    }

    public class SortableGameVersion
    {
        [J("gameVersionName")] public string? GameVersionName { get; set; }
        [J("gameVersionPadded")] public string? GameVersionPadded { get; set; }
        [J("gameVersion")] public string? GameVersion { get; set; }
        [J("gameVersionReleaseDate")] public DateTimeOffset GameVersionReleaseDate { get; set; }
        [J("gameVersionTypeId")] public long GameVersionTypeId { get; set; }
    }

    public class LatestFilesIndex
    {
        [J("gameVersion")] public string? GameVersion { get; set; }
        [J("fileId")] public long FileId { get; set; }
        [J("filename")] public string? Filename { get; set; }
        [J("releaseType")] public long ReleaseType { get; set; }
        [J("gameVersionTypeId")] public long GameVersionTypeId { get; set; }
        [J("modLoader")] public long ModLoader { get; set; }
    }

    public class Links
    {
        [J("websiteUrl")] public string? WebsiteUrl { get; set; }
        [J("wikiUrl")] public string? WikiUrl { get; set; }
        [J("issuesUrl")] public string? IssuesUrl { get; set; }
        [J("sourceUrl")] public string? SourceUrl { get; set; }
    }

    public class Logo
    {
        [J("id")] public long Id { get; set; }
        [J("modId")] public long ModId { get; set; }
        [J("title")] public string? Title { get; set; }
        [J("description")] public string? Description { get; set; }
        [J("thumbnailUrl")] public string? ThumbnailUrl { get; set; }
        [J("url")] public string? Url { get; set; }
    }
}