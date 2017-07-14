using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Find.Helpers.Text;
using EPiServer.Web;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BbmUnderlakare.Data.Models.Pages.Base
{
    public class ContentPageBase : MetaDataPageBase
    {
        [CultureSpecific]
        [Searchable]
        [Display(GroupName = GroupNames.Tabs.Content, Order = 120)]
        public virtual string Heading
        {
            get
            {
                var pageHeading = this.GetPropertyValue(p => p.Heading);

                // Use explicitly set page title, otherwise fall back to page name
                return !string.IsNullOrWhiteSpace(pageHeading)
                    ? pageHeading
                    : PageName;
            }
            set
            {
                if (Heading != null)
                    this.SetPropertyValue(p => p.Heading, value);
            }

        }

        [UIHint(UIHint.Textarea)]
        [CultureSpecific]
        [Display(GroupName = GroupNames.Tabs.Content, Order = 130)]
        public virtual string Preamble { get; set; }

        [CultureSpecific]
        [Display(GroupName = GroupNames.Tabs.Content, Order = 140)]
        public virtual XhtmlString Body { get; set; }

        public string PreambleText
        {
            get
            {
                if (!string.IsNullOrEmpty(this.Preamble))
                {
                    return this.Preamble;
                }

                if (this.Body != null)
                {
                    var body = this.Body.ToString().StripHtml().Split('.');

                    if (body.Length > 1)
                    {
                        return $"{body[0]}. {body[1]}.";
                    }
                }

                return string.Empty;
            }
        }
    }
}