using BbmUnderlakare.Business.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BbmUnderlakare.Business.Entities
{
    public class SearchResult : ISearchResult
    {
        public SearchResult(string name, string info, DateTime? publishDate, string section)
        {
            Name = name;
            Info = info;
            PublishDate = publishDate;
            Section = section;
        }

        public string Name { get; set; }
        public string Info { get; set; }
        public DateTime? PublishDate { get; set; }
        public string Section { get; set; }
    }
}