using J = System.Text.Json.Serialization.JsonPropertyNameAttribute;

namespace Yoonir.Curseforge.Model;

public class GetModRsp
{
    [J("data")] public Mod? Rsp { get; set; }
}