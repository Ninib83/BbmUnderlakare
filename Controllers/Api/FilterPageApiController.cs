using BbmUnderlakare.Business.Entities;
using BbmUnderlakare.Business.Services.Interfaces;
using BbmUnderlakare.Models.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;

namespace BbmUnderlakare.Controllers.Api
{
    [RoutePrefix("api/v1/filter")]
    public class FilterPageApiController : ApiController
    {
        private readonly ILogService _logService;
        private readonly IFilterService _filterService;
        public FilterPageApiController(ILogService logService, IFilterService filterService)
        {
            this._logService = logService;
            this._filterService = filterService;
        }


        [HttpGet]
        [Route("")]
        public IHttpActionResult FilterHospital(int ingangsLon, int sTLon, bool ensamPaNattjour, bool betaldAtStamma, bool ledarskapsutbildning, bool personalbostad, bool hjalpAttHittaBoende, bool mojlighetTillVikariat, bool sTTjansterErbjuds)
        {
            _logService.Info($"{DateTime.Now} - Getting site page");

            var page = _filterService.FilterHospital(ingangsLon, sTLon, ensamPaNattjour, betaldAtStamma, ledarskapsutbildning, personalbostad, hjalpAttHittaBoende, mojlighetTillVikariat, sTTjansterErbjuds);
            if (page == null)
            {
                return Content(HttpStatusCode.NotFound,
                    new ApiResponse("Sidan hittades inte", (int)HttpStatusCode.NotFound));
            }

            return Ok(page);

            //throw new Exception("fel!");
        }
    }
}