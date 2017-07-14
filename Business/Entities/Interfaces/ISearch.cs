using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BbmUnderlakare.Business.Entities.Interfaces
{
    public interface ISearch
    {
        string SearchTerm { get; set; }
        int Size { get; set; }
        int Page { get; set; }
    }
}