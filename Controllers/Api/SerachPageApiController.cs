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
    [RoutePrefix("api/v1/search")]
    public class SerachPageApiController :ApiController
    {
        private readonly ISerachService _searchService;
        private readonly ILogService _logService;
        public SerachPageApiController(ISerachService searchService, ILogService logService)
        {
            this._searchService = searchService;
            this._logService = logService;
        }

        [HttpGet]
        [Route("")]
        public IHttpActionResult SearchPage(string searchQuery)
        {
            _logService.Info($"{DateTime.Now} - Getting site page");

            var page = _searchService.GetSerachResults(searchQuery);
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