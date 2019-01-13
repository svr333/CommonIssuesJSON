using CI.JsonParser.Core.Interfaces;
using CI.JsonParser.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CI.JsonParser.Core
{
    public class Json : IJson
    {
        private readonly string JsonUrl = "https://raw.githubusercontent.com/DraxCodes/common-issues/master/CommonIssue.json";

        public async Task<List<CommonIssue>> Deserialize()
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
