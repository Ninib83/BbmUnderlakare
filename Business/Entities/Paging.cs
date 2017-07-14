//using BbmUnderlakare.Business.Helpers;
using BbmUnderlakare.Business.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BbmUnderlakare.Business.Entities
{
    public class Paging : IPaging
    {
        public bool HasMoreItems { get; set; }
        public int Page { get; set; }
        public int TotalHits { get; set; }
    }

    //public class Paging<T> : Paging
    //{
    //    public Paging()
    //    {
    //    }

    //    public Paging(IEnumerable<T> items, int size, int page)
    //    {
    //        if (page <= 0)
    //        {
    //            page = 1;
    //        }
    //        var list = items.ToList();

    //        Items = list.Skip(SearchHelper.GetItemsToSkip(size, page)).Take(size);
    //        HasMoreItems = page * size < list.Count;
    //        Page = page;
    //        TotalHits = list.Count;
    //    }

    //    public IEnumerable<T> Items { get; set; }
    //}
}