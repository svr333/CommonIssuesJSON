using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CI.JsonParser.Core;
using CI.JsonParser.Entities;
using CI.JsonParser.Interfaces;

namespace CI.JsonParser
{
    public class CIClient : ICICLient
    {
        private Json Json = new Json();

        public async Task<CommonIssue> SearchCommonIssuesAsync(string search)
        {
            var issues = await Json.Deserialize();
            return issues.Where(x => x.Aliases.ConvertAll(a => a.ToLower()).Contains(search)).FirstOrDefault();
        }

        public async Task<List<CommonIssue>> GetCommonIssuesAsync()
        {
            return await Json.Deserialize();
        }
    }
}
