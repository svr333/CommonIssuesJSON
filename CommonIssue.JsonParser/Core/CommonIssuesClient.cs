using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommonIssues.JsonParser.Core;
using CommonIssues.JsonParser.Entities;
using CommonIssues.JsonParser.Interfaces;

namespace CommonIssues.JsonParser
{
    public class CommonIssuesClient : ICommonIssuesClient
    {
        private CommonIssuesProvider _CommonIssuesProvider = new CommonIssuesProvider();

        /// <summary>
        /// Searches the repo for an exact match of [Search]
        /// </summary>
        /// <param name="search">The String To Search For</param>
        /// <returns></returns>
        public async Task<CommonIssue> SearchCommonIssuesAsync(string search)
        {
            var issues = await _CommonIssuesProvider.RetrieveData();
            return issues.FirstOrDefault(x => x.Name.ToLower() == search.ToLower());
        }

        /// <summary>
        /// Returns all of the issues from the CommonIssues Repo
        /// </summary>
        /// <returns>List Of CommonIssues</returns>
        public async Task<List<CommonIssue>> GetCommonIssuesAsync()
        {
            return await _CommonIssuesProvider.RetrieveData();
        }

        /// <summary>
        /// Searches for any partial matches of [Search] Returns a max of 4 results.
        /// </summary>
        /// <param name="search">The String To Search For</param>
        /// <returns>List of CommonIssues, Max 4</returns>
        public async Task<List<CommonIssue>> GetPartialMatches(string search)
        {
            var issues = await _CommonIssuesProvider.RetrieveData();
            return issues.FindAll(x =>
                x.Aliases.Any(a =>
                a.ToLower().Contains(search.ToLower()))).Take(4).ToList();
        }
    }
}
