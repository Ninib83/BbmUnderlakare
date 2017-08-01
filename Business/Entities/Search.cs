using BbmUnderlakare.Business.Entities.Interfaces;
using EPiServer.Find.UnifiedSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BbmUnderlakare.Business.Services
{
    public class Search : ISearch
    {
        public Search(string searchQuery)
        {
            SearchQuery = searchQuery;
        }
        public string SearchQuery { get; set; }
        public UnifiedSearchResults Results { get; set; }
    }

}