using System.Collections.Generic;

namespace CI.JsonParser.Entities
{
    public class CommonIssue
    {
        public string Name { get; set; }
        public List<string> Aliases { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
    }
}
