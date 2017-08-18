using BbmUnderlakare.Business.Entities;
using BbmUnderlakare.Business.Extensions;
using BbmUnderlakare.Business.Filters;
using BbmUnderlakare.Business.Services.Interfaces;
using BbmUnderlakare.Models.Pages;
using EPiServer.Find;
using EPiServer.Find.Cms;
using EPiServer.Find.Framework;
using EPiServer.Find.Framework.Statistics;
using EPiServer.Find.UnifiedSearch;
using System;
using System.Collections.Generic;

namespace BbmUnderlakare.Business.Services
{
    public class SearchService : ISearchService
    {

        #region Sök funktion
        public IEnumerable<SearchResult> GetSearchResults(string searchQuery)
        {
            List<SearchResult> resultList = new List<SearchResult>();

            var hitSpec = new HitSpecification
            {
                HighlightExcerpt = false,
                EncodeTitle = false,
                EncodeExcerpt = false
            };

            var model = new Search(searchQuery);
            if (String.IsNullOrEmpty(searchQuery))
            {
                return resultList;
            }

            var unifiedSearch = SearchClient.Instance
            .UnifiedSearch().For(searchQuery)
            .WildCardQuery(string.Concat(searchQuery, "*"), x => x.SearchTitle)
            .WildCardQuery(string.Concat(searchQuery, "*"), x => x.SearchText)
            .Track();

            model.Results = unifiedSearch
                .ApplyBestBets(200)
                .GetResult(hitSpec);

            foreach (var item in model.Results)
            {
                var prop = new SearchResult(item.Title, item.Excerpt, item.PublishDate, item.Section);
                resultList.Add(prop);
            }

            return resultList;
        }
        #endregion

      

    }
}