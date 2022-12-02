using System.Net.Http.Json;
using Yoonir.Modrinth.Model;

namespace Yoonir.Modrinth
{
    public class ModrinthApi
    {
        private const string API_BASE = "https://api.modrinth.com/v2";
        private HttpClient Client { get; set; } = new HttpClient();
        public string Key { private get; init; }

        /// <summary>
        /// Modrinth API Entry.
        /// https://docs.modrinth.com/api-spec/
        /// </summary>
        /// <param name="key">GitHub authorization token.
        /// </param>
        public ModrinthApi(string key)
        {
            Key = key;
            Client.DefaultRequestHeaders.Add("Authorization", Key);
            Client.DefaultRequestHeaders.Add("Accept", "application/json");
        }

        /// <summary>
        /// Get a project.
        /// </summary>
        /// <param name="key">
        /// Example: <code>AABBCCDD,my_project</code>
        /// The ID or slug of the project.
        /// </param>
        /// <returns>
        /// Parsed JSON response.
        /// </returns>
        public async Task<ModrinthGetProjectRsp?> GetProject(string key)
        {
            return await Client.GetFromJsonAsync<ModrinthGetProjectRsp>($"/search/{key}");
        }

        /// <summary>
        /// Search projects.
        /// </summary>
        /// <returns>
        /// Parsed JSON response.
        /// </returns>
        public async Task<ModrinthSearchResultRsp?> SearchProjects()
        {
            //TODO: impl
            return null;
        }

        /// <summary>
        /// Get multiple projects.
        /// </summary>
        /// <param name="ids">
        /// List of strings.
        /// Example: <code>ids=["AABBCCDD", "EEFFGGHH"]</code>.
        /// The IDs of the projects.
        /// </param>
        /// <returns>
        /// Parsed JSON response.
        /// </returns>
        public async Task<List<ModrinthGetProjectRsp?>?> GetMultipleProjects(List<string> ids)
        {
            var query = new Dictionary<string, List<string>> { ["query"] = ids };
            return await Client.GetFromJsonAsync<List<ModrinthGetProjectRsp?>>($"/projects");
        }

        /// <summary>
        /// Get all of a project's dependencies.
        /// </summary>
        /// <param name="id">
        /// Example: <code>AABBCCDD,my_project</code>
        /// The ID or slug of the project.
        /// </param>
        /// <returns>
        /// Parsed JSON response.
        /// </returns>
        public async Task<ModrinthGetProjAllDependsRsp?>? GetProjectAllDependencies(string id)
        {
            return await Client.GetFromJsonAsync<ModrinthGetProjAllDependsRsp>($"/project/{id}/dependencies");
        }

        /// <summary>
        /// Check project slug/ID validity.
        /// </summary>
        /// <param name="id">
        /// Example: <code>AABBCCDD,my_project</code>
        /// The ID or slug of the project.
        /// </param>
        /// <returns>
        /// Parsed JSON response.
        /// </returns>
        public async Task<ModrinthCheckProjIdValidityRsp?>? CheckProjectValidity(string id)
        {
            return await Client.GetFromJsonAsync<ModrinthCheckProjIdValidityRsp>($"/project/{id}/check");
        }
    }
}
