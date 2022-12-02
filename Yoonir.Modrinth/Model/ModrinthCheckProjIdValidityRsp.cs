using J = System.Text.Json.Serialization.JsonPropertyNameAttribute;

namespace Yoonir.Modrinth.Model;

public class ModrinthCheckProjIdValidityRsp
{
    [J("id")] public string? Id { get; set; }
}