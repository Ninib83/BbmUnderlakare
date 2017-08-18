using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using System.Collections.Generic;

namespace BbmUnderlakare.Models.Pages
{
    [ContentType(DisplayName = "SearchFilterPage", GUID = "b1a8fbb7-5496-494f-86eb-8cf93e2ba375", Description = "")]
    public class SearchFilterPage : PageData
    {

        //[CultureSpecific]
        //[Display(
        //    Name = "Hospitals",
        //    Description = "",
        //    GroupName = SystemTabNames.Content,
        //    Order = 10)]
        //public virtual IList<HospitalFormAt> Hospitals { get; set; }

    }
}