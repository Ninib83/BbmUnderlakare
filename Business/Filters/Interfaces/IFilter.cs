using BbmUnderlakare.Models.Pages;
using EPiServer.Find.Cms;
using EPiServer.Find.UnifiedSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BbmUnderlakare.Business.Filters.Interfaces
{
    public interface IFilter
    {
        int IngangsLon { get; set; }
        int STLon { get; set; }
        bool EnsamPaNattjour { get; set; }
        bool BetaldATStamma { get; set; }
        bool Ledarskapsutbildning { get; set; }
        bool Personalbostad { get; set; }
        bool HjalpAttHittaBoende { get; set; }
        bool MojlighetTillVikariat { get; set; }
        bool STTjansterErbjuds { get; set; }
    }
}