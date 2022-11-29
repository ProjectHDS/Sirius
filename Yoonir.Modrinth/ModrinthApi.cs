using System.Net.Http.Json;
using Yoonir.Modrinth.Model;

namespace Yoonir.Modrinth
{
    public class ModrinthApi
    {
        private const string API_BASE = "https://api.modrinth.com/v2";
        private HttpClient Client { get; set; } = new HttpClient();
        public string Key { private get; init; }

        public ModrinthApi(string key)
        {
            Key = key;
            Client.DefaultRequestHeaders.Add("Authorization", Key);
            Client.DefaultRequestHeaders.Add("Accept", "application/json");
        }

        public async Task<ModrinthGetProjectRsp?> GetProject(string key)
        {
            return await Client.GetFromJsonAsync<ModrinthGetProjectRsp>($"/search/{key}");
        }
    }
}