using System.Net.Http.Headers;
using System.Net.Http.Json;
using Yoonir.Curseforge.Model;

namespace Yoonir.Curseforge;

public partial class CurseforgeApi
{
    private const string API_BASE = "https://api.curseforge.com";
    private HttpClient Client { get; set; } = new HttpClient();
    public string Key { private get; init; }

    public CurseforgeApi(string key)
    {
        Key = key;
        Client.BaseAddress = new Uri(API_BASE);
        Client.DefaultRequestHeaders.Add("x-api-key", Key);
        Client.DefaultRequestHeaders.Add("Accept", "application/json");
    }

    public async Task<CurseforgeGetModRsp?> GetMod(string id)
    {
        return await Client.GetFromJsonAsync<CurseforgeGetModRsp>($"/v1/mods/{id}");
    }

    public async Task<CurseforgeGetModRsp?> GetMod(long id)
    {
        return await GetMod(id.ToString());
    }
}