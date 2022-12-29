#nullable disable
using J = System.Text.Json.Serialization.JsonPropertyNameAttribute;

namespace Yoonir.Curseforge.Model;

public class GetFingerprintMatchesRsp
{
    [J("data")] public GetFingerprintMatchesRspData GetFingerprintMatchesRspData { get; set; }
}

public class GetFingerprintMatchesRspData
{
    [J("isCacheBuilt")] public bool IsCacheBuilt { get; set; }
    [J("exactMatches")] public ExactMatch[] ExactMatches { get; set; }
    [J("exactFingerprints")] public long[] ExactFingerprints { get; set; }
    [J("partialMatches")] public object[] PartialMatches { get; set; }
    [J("partialMatchFingerprints")] public object PartialMatchFingerprints { get; set; }
    [J("installedFingerprints")] public long[] InstalledFingerprints { get; set; }
    [J("unmatchedFingerprints")] public object UnmatchedFingerprints { get; set; }
}

public class ExactMatch
{
    [J("id")] public long Id { get; set; }
    [J("file")] public FileInformation File { get; set; }
    [J("latestFiles")] public FileInformation[] LatestFiles { get; set; }
}

public class FileInformation
{
    [J("id")] public long Id { get; set; }
    [J("gameId")] public long GameId { get; set; }
    [J("modId")] public long ModId { get; set; }
    [J("isAvailable")] public bool IsAvailable { get; set; }
    [J("displayName")] public string DisplayName { get; set; }
    [J("fileName")] public string FileName { get; set; }
    [J("releaseType")] public long ReleaseType { get; set; }
    [J("fileStatus")] public long FileStatus { get; set; }
    [J("hashes")] public object[] Hashes { get; set; }
    [J("fileDate")] public object FileDate { get; set; }
    [J("fileLength")] public long FileLength { get; set; }
    [J("downloadCount")] public long DownloadCount { get; set; }
    [J("downloadUrl")] public Uri DownloadUrl { get; set; }
    [J("gameVersions")] public string[] GameVersions { get; set; }
    [J("sortableGameVersions")] public object[] SortableGameVersions { get; set; }
    [J("dependencies")] public object[] Dependencies { get; set; }
    [J("alternateFileId")] public long AlternateFileId { get; set; }
    [J("isServerPack")] public bool IsServerPack { get; set; }
    [J("fileFingerprint")] public long FileFingerprint { get; set; }
    [J("modules")] public object[] Modules { get; set; }
}