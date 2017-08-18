using BbmUnderlakare.Models.Pages;
using EPiServer.Find;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BbmUnderlakare.Business.Extensions
{
    public static class HospitalFilterExtensions
    {
        public static FilterExpression<HospitalFormAt> HospitalExists(this HospitalFormAt hospital)
        {
            return new FilterExpression<HospitalFormAt>(
                x => x.ContentLink.ID.Exists());
        }

        public static FilterExpression<HospitalFormAt> SalaryExists(this HospitalFormAt hospital)
        {
            return new FilterExpression<HospitalFormAt>(
                h => h.Ingangslon.InRange("0", "20000")
                | h.Ingangslon.Exists());
        }


        public static FilterExpression<HospitalFormAt> IsNightShift(this HospitalFormAt hospital)
        {
            return new FilterExpression<HospitalFormAt>(
                h => h.EnsamPaNattjour.Exists());
        }


    }
}