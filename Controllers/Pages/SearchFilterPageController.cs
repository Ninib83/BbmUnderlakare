using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using BbmUnderlakare.Models.Pages;
using EPiServer.Find;
using EPiServer.Find.UI;
using BbmUnderlakare.Models.ViewModels;
using EPiServer.Find.Cms;
using BbmUnderlakare.Business.Entities;
using EPiServer.Find.Framework;
using EPiServer.Find.Framework.Statistics;
using System;

namespace BbmUnderlakare.Controllers.Pages
{
    public class SearchFilterPageController : PageController<SearchFilterPage>
    {
        public IEnumerable<AtForm> Index(SearchFilterPage currentFilterPage, int ingangsLon, bool lonEfter18Manader)
        {
            List<AtForm> resultList = new List<AtForm>();


            var model = new SearchFilterPageViewModel(currentFilterPage, ingangsLon, lonEfter18Manader);

            var filter = SearchClient.Instance.Search<HospitalFormAt>()
            .Filter(x => x.Ingangslon.Match(ingangsLon)).ApplyBestBets(200).Track()
            .Filter(x => x.LonEfter18Manader.Match(lonEfter18Manader)).ApplyBestBets(200).Track()
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
    }
}