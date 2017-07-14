using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BbmUnderlakare.Data.Entities.ElasticSearch.Interfaces
{
    public interface IPageWatcher
    {
        string Id { get; set; }
        Guid UserId { get; set; }
        int SiteId { get; set; }
        QueryContainer Query { get; set; }
    }
}