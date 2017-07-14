using EPiServer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BbmUnderlakare.Data.Models.Pages.Interfaces
{
    public interface IWatchablePage
    {
        string Heading { get; }
        string Preamble { get; }
        XhtmlString Body { get; }
        int SiteId { get; }
        bool IsOpen { get; }
        string PageTypeNameAsString { get; }
    }
}