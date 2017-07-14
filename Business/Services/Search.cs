using BbmUnderlakare.Business.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BbmUnderlakare.Business.Services
{
    public class Search : ISearch
    {
        public int Page { get; set; }
        public string SearchTerm { get; set; }
        public int Size { get; set; }
    }
}