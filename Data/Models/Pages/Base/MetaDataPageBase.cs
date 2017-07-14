using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BbmUnderlakare.Data.Models.Pages.Base
{
    public class MetaDataPageBase : SitePageBase
    {
        [CultureSpecific]
        [Searchable]
        [Display(GroupName = GroupNames.Tabs.Seo, Order = 500)]
        public virtual string MetaTitle
        {
            get
            {
                var metaTitle = this.GetPropertyValue(p => p.MetaTitle);

                // Use explicitly set meta title, otherwise fall back to page name
                return !string.IsNullOrWhiteSpace(metaTitle)
                       ? metaTitle
                       : PageName;
            }
            set
            {
                if (MetaTitle != null)
                    this.SetPropertyValue(p => p.MetaTitle, value);

            }
        }

        [CultureSpecific]
        [Searchable]
        [UIHint(UIHint.Textarea)]
        [Display(GroupName = GroupNames.Tabs.Seo, Order = 510)]
        public virtual string MetaDescription { get; set; }
    }
}