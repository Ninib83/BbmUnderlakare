using BbmUnderlakare.Business.Filters.Interfaces;
using BbmUnderlakare.Models.Pages;
using EPiServer.Find.Cms;
using EPiServer.Find.UnifiedSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BbmUnderlakare.Business.Filters
{
    public class Filter : IFilter
    {
        public Filter( int ingangsLon, int sTLon, bool ensamPaNattjour, bool betaldAtStamma, bool ledarskapsutbildning, bool personalbostad, bool hjalpAttHittaBoende, bool mojlighetTillVikariat, bool sTTjansterErbjuds) 
        {
            IngangsLon = ingangsLon;
            STLon = sTLon;
            EnsamPaNattjour = ensamPaNattjour;
            BetaldATStamma = betaldAtStamma;
            Ledarskapsutbildning = ledarskapsutbildning;
            Personalbostad = personalbostad;
            HjalpAttHittaBoende = hjalpAttHittaBoende;
            MojlighetTillVikariat = mojlighetTillVikariat;
            STTjansterErbjuds = sTTjansterErbjuds;
        }

        public int STLon { get; set; }
        public int IngangsLon { get; set; }
        public bool EnsamPaNattjour { get; set; }
        public bool BetaldATStamma { get; set; }
        public bool Ledarskapsutbildning { get; set; }
        public bool Personalbostad { get; set; }
        public bool HjalpAttHittaBoende { get; set; }
        public bool MojlighetTillVikariat { get; set; }
        public bool STTjansterErbjuds { get; set; }
    }
}