
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using BbmUnderlakare.Models.Pages;
using BbmUnderlakare.Models.ViewModels;
using System;

namespace BbmUnderlakare.Controllers.Pages
{
    public class HospitalFormAtController : PageController<HospitalFormAt>
    {
        public ActionResult Index(HospitalFormAt currentPage)
        {
            //var hospitalModel = new AllHospitalAtViewmodel(hospitalPage);
            //if (hospitalPage != null)
            //{
            //    return View(hospitalModel);
            //}

            //var model = new List<HospitalFormAt>();
            //model.Add(new HospitalFormAt() { });

            return View(currentPage);
        }
    }
}