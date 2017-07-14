using BbmUnderlakare.Models.Pages;
using EPiServer.Find;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BbmUnderlakare.Business.Extensions
{
    public static class FilterExtension
    {

            public static FilterExpression<HospitalFormAt> Exists(this HospitalFormAt hospitalFormAt)
            {
                return new FilterExpression<HospitalFormAt>(
                    x => x.ContentLink.ID.Exists());
            }
        
    }
}