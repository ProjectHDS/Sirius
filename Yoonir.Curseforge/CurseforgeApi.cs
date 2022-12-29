using System.Net.Http.Headers;
using System.Net.Http.Json;

using Yoonir.Curseforge.Model;
using Yoonir.Curseforge.Util;

namespace Yoonir.Curseforge;

public partial class CurseforgeApi
{
    private const string ApiBase = "https://api.curseforge.com";
    private HttpClient Client { get; set; } = new HttpClient();
    public string Key { private get; init; }

    public CurseforgeApi(string key)
    {
        Key = key;
        Client.BaseAddress = new Uri(ApiBase);
        Client.DefaultRequestHeaders.Add("x-api-key", Key);
        Client.DefaultRequestHeaders.Add("Accept", "application/json");
    }

    public async Task<GetModRsp?> GetModAsync(string id)
    {
        return await Client.GetFromJsonAsync<GetModRsp>($"/v1/mods/{id}");
    }

    public async Task<GetModRsp?> GetModAsync(long id)
    {
        return await GetModAsync(id.ToString());
    }

    public async Task<GetModsRsp?> GetModAsync(params string[] ids)
    {
        var rsp = await Client.PostAsJsonAsync("/v1/mods", new { modIds = ids });
        if (rsp.IsSuccessStatusCode)
        {
            return await rsp.Content.ReadFromJsonAsync<GetModsRsp>();
        }

        throw new HttpRequestException(rsp.ReasonPhrase);
    }

    public async Task<GetFingerprintMatchesRsp?> GetFilesInformationAsync(byte[][] files)
    {
        var rsp = await Client.PostAsJsonAsync("/v1/fingerprints", new { fingerprints = files.Select(MurmurHash2.HashNormal) });
        if (rsp.IsSuccessStatusCode)
        {
            return await rsp.Content.ReadFromJsonAsync<GetFingerprintMatchesRsp>();
        }

        throw new HttpRequestException(rsp.ReasonPhrase);
    }
}