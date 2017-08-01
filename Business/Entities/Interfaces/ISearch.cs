using EPiServer.Find.UnifiedSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BbmUnderlakare.Business.Entities.Interfaces
{
    public interface ISearch
    {
         string SearchQuery { get; set; }
         UnifiedSearchResults Results { get; set; }
    }
}