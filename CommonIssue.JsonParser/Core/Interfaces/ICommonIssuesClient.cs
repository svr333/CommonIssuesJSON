using CI.JsonParser.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CI.JsonParser.Interfaces
{
    public interface ICommonIssuesClient
    {
        Task<List<CommonIssue>> GetCommonIssuesAsync();
        Task<CommonIssue> SearchCommonIssuesAsync(string name);
    }
}
