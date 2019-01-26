using CommonIssues.JsonParser.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommonIssues.JsonParser.Core.Interfaces
{
    public interface ICommonIssuesProvider
    {
        Task<List<T>> RetrieveData<T>();
    }
}
