using CI.JsonParser.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CI.JsonParser.Interfaces
{
    public interface ICICLient
    {
        Task<List<CommonIssue>> GetCommonIssuesAsync();
        Task<CommonIssue> SearchCommonIssuesAsync(string name);
    }
}
