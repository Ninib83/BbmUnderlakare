using BbmUnderlakare.Models.Pages;
using EPiServer.Find.UnifiedSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BbmUnderlakare.Models.ViewModels
{
    public class SearchFilterPageViewModel : PageViewModel<SearchFilterPage>
    {
        public SearchFilterPageViewModel(SearchFilterPage searchFilterPage, int ingangsLon, bool lonEfter18Manader) 
            : base(searchFilterPage)
        {
            IngangsLon = ingangsLon;
            LonEfter18Manader = lonEfter18Manader;
        }

        public int IngangsLon { get; set; }
        public bool LonEfter18Manader { get; set; }
        
        public UnifiedSearchResults Results { get; set; }
    }
}