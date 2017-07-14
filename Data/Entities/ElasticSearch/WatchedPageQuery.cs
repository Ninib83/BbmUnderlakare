using BbmUnderlakare.Data.Entities.ElasticSearch.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BbmUnderlakare.Data.Entities.ElasticSearch
{
    public class WatchedPageQuery : IWatchedPageQuery
    {
        public string Heading { get; set; }
        public string Preamble { get; set; }
        public string Body { get; set; }
        public string AuthorName { get; set; }
        public int SiteId { get; set; }
    }
}