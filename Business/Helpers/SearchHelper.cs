using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BbmUnderlakare.Business.Helpers
{
    public static class SearchHelper
    {
        public static int GetItemsToSkip(int size, int page)
        {
            page = page < 1 ? 1 : page;
            var skip = (page - 1) * size;
            return skip;
        }
    }
}