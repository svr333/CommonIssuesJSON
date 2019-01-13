using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CI.JsonParser.Core;
using CI.JsonParser.Entities;
using CI.JsonParser.Interfaces;

namespace CI.JsonParser
{
    public class CommonIssuesClient : ICommonIssuesClient
    {
        private CommonIssuesProvider _CommonIssuesProvider = new CommonIssuesProvider();

        public async Task<CommonIssue> SearchCommonIssuesAsync(string search)
        {
            var issues = await _CommonIssuesProvider.RetrieveData();
            return issues.FirstOrDefault(x => 
                x.Aliases.Any(a => 
                a.ToLower().Contains(search.ToLower())));
        }

        public async Task<List<CommonIssue>> GetCommonIssuesAsync()
        {
            return await _CommonIssuesProvider.RetrieveData();
        }
        
    }
}
