﻿using CI.JsonParser.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CI.JsonParser.Core.Interfaces
{
    public interface IJson
    {
        Task<List<CommonIssue>> Deserialize();
    }
}