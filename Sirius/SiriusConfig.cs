using System.Text.Json.Serialization;
using Sirius.formats;

namespace Sirius;

using J = JsonPropertyNameAttribute;

public class SiriusConfig
{
    [J("modpackName")] public string ModpackName { get; set; }
    [J("architectureName")] public string ArchitectureName { get; set; }
    [J("targetFormats")] public string[] TargetFormats { get; set; }
    [J("rootAbsolutePath")] public string RootAbsolutePath { get; set; }
}

[JsonSerializable(typeof(SiriusConfig))]
public partial class SiriusConfigContext : JsonSerializerContext
{
}
