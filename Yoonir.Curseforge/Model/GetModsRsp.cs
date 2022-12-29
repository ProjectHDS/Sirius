using J = System.Text.Json.Serialization.JsonPropertyNameAttribute;

namespace Yoonir.Curseforge.Model;

public class GetModsRsp
{
    [J("data")] public List<Mod>? Rsp { get; set; }
}