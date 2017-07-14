using BbmUnderlakare.Data.Entities.ElasticSearch.Interfaces;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BbmUnderlakare.Data.Entities.ElasticSearch
{
    [ElasticsearchType(IdProperty = nameof(Id))]
    public class PageWatcher : IPageWatcher
    {
        public string Id { get; set; }
        public Guid UserId { get; set; }
        public int SiteId { get; set; }
        public QueryContainer Query { get; set; }
    }
}