using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BbmUnderlakare.Business.Entities.Interfaces
{
    public interface ISearchResult
    {
        string Name { get; set; }
        string Info { get; set; }
        DateTime? PublishDate { get; set; }
        string Section { get; set; }
    }
}