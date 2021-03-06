﻿using BbmUnderlakare.Models.Pages;

namespace BbmUnderlakare.Models.ViewModels
{
    public class PageViewModel<T>
    {
        private SearchPage currentPage;

        public PageViewModel(SearchPage currentPage)
        {
            this.currentPage = currentPage;
        }

        private SearchFilterPage currentFilterPage;

        public PageViewModel(SearchFilterPage currentFilterPage)
        {
            this.currentFilterPage = currentFilterPage;
        }

    }
}