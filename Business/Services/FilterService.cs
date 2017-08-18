using BbmUnderlakare.Business.Entities;
using BbmUnderlakare.Business.Services.Interfaces;
using BbmUnderlakare.Models.Pages;
using EPiServer.Find;
using EPiServer.Find.Cms;
using EPiServer.Find.Framework;
using EPiServer.Find.Framework.Statistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BbmUnderlakare.Business.Services
{
    public class FilterService : IFilterService
    {
        #region Filter Funktion
        public IEnumerable<AtForm> FilterHospital(int ingangsLon, int sTLon, bool ensamPaNattjour, bool betaldAtStamma, bool ledarskapsutbildning, bool personalbostad, bool hjalpAttHittaBoende, bool mojlighetTillVikariat, bool sTTjansterErbjuds)
        {
            List<AtForm> resultList = new List<AtForm>();

            var filter = SearchClient.Instance.Search<HospitalFormAt>()
            .Filter(x => x.Ingangslon.Match(ingangsLon)).ApplyBestBets(200).Track()
            .Filter(x => x.STLon.Match(sTLon)).ApplyBestBets(200).Track()
            .Filter(x => x.EnsamPaNattjour.Match(ensamPaNattjour)).ApplyBestBets(200).Track()
            .Filter(x => x.BetaldATStamma.Match(betaldAtStamma)).ApplyBestBets(200).Track()
            .Filter(x => x.Ledarskapsutbildning.Match(ledarskapsutbildning)).ApplyBestBets(200).Track()
            .Filter(x => x.Personalbostad.Match(personalbostad)).ApplyBestBets(200).Track()
            .Filter(x => x.HjalpAttHittaBoende.Match(hjalpAttHittaBoende)).ApplyBestBets(200).Track()
            .Filter(x => x.MojlighetTillVikariat.Match(mojlighetTillVikariat)).ApplyBestBets(200).Track()
            .Filter(x => x.STTjansterErbjuds.Match(sTTjansterErbjuds)).ApplyBestBets(200).Track()
            .GetContentResult();


            foreach (var item in filter)
            {
                var prop = new AtForm(item.ContentLink.ID,
                                                 item.Name,
                                                 item.Huvudman,
                                                 item.ATblockensLangd,
                                                 item.ATBlockTermin,
                                                 item.AntalSokandeBlock,
                                                 item.Ingangslon,
                                                 item.LonEfter18Manader,
                                                 item.STLon,
                                                 item.Studiepott,
                                                 item.Personalbostad,
                                                 item.HyresnivaTreaRok,
                                                 item.Bostadsmarknad,
                                                 item.HjalpAttHittaBoende,
                                                 item.Introduktion,
                                                 item.Undervisning,
                                                 item.HandledareHuvudansvar,
                                                 item.MentorHuvudhandledare,
                                                 item.Ledarskapsutbildning,
                                                 item.BetaldATStamma,
                                                 item.EnsamPaNattjour,
                                                 item.STTjansterErbjuds,
                                                 item.MojlighetTillVikariat,
                                                 item.ObesattaTjanster,
                                                 item.Upptagningsomrade,
                                                 item.Ovrigt,
                                                 item.Kontaktperson);
                resultList.Add(prop);
            }

            return resultList;

        }

        #endregion
    }
}