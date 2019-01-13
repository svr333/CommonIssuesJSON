using CommonIssues.JsonParser.Core.Interfaces;
using CommonIssues.JsonParser.Entities;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace CommonIssues.JsonParser.Core
{
    public class CommonIssuesProvider : ICommonIssuesProvider
    {
        private readonly string JsonUrl = "https://raw.githubusercontent.com/DraxCodes/common-issues/master/CommonIssue.json";

        public async Task<List<CommonIssue>> RetrieveData()
        {
            var rawData = await GetRawData();
            return JsonConvert.DeserializeObject<List<CommonIssue>>(rawData);
        }

        private async Task<string> GetRawData()
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage message = await client.GetAsync(JsonUrl);
                message.EnsureSuccessStatusCode();
                return await message.Content.ReadAsStringAsync();
            }
        }
    }
}
