using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BbmUnderlakare.Data.Entities.ElasticSearch.Interfaces
{
    public interface IWatchedPageQuery
    {
        string Heading { get; set; }
        string Preamble { get; set; }
        string Body { get; set; }
        string AuthorName { get; set; }
        int SiteId { get; set; }
    }
}