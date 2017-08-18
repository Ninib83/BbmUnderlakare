using BbmUnderlakare.Business.Entities;
using BbmUnderlakare.Models.Pages;
using BbmUnderlakare.Models.ViewModels;
using EPiServer.Find.Cms;
using EPiServer.Find.UnifiedSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BbmUnderlakare.Business.Services.Interfaces
{
    public interface ISearchService
    {
       IEnumerable<SearchResult> GetSearchResults(string searchQuery);
    }
}