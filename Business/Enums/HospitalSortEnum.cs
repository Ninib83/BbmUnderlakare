using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BbmUnderlakare.Business.Enums
{
    public enum HospitalSortEnum
    {

            [Display(Name = "Relevance")]
            Relevance = 0,
            [Display(Name = "SortOrderIndex")]
            Index = 1,
            [Display(Name = "StartPublish")]
            DateDesc = 2,
            [Display(Name = "StartPublish")]
            DateAsc = 3
    }
}