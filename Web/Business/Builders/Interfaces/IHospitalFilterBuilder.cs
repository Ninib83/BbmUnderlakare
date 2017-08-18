using BbmUnderlakare.Business.Entities.Interfaces;
using BbmUnderlakare.Models.Pages;
using EPiServer.Find;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BbmUnderlakare.Web.Business.Builders.Interfaces
{
    public interface IHospitalFilterBuilder
    {
        IEnumerable<FilterBuilder<HospitalFormAt>> BuildFilters(ISearchResult hospitalSearch, bool includeSuggestedHospitals = false);
        IEnumerable<FilterBuilder<HospitalFormAt>> BuildOpenFilters(ISearchResult hospitalSearch, bool includeSuggestedHospitals = false);
    }
}