
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
            return View(currentPage);
        }
    }
}