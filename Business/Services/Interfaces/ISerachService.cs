using BbmUnderlakare.Business.Entities;
using BbmUnderlakare.Models.Pages;
using BbmUnderlakare.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BbmUnderlakare.Business.Services.Interfaces
{
    public interface ISerachService
    {
       IEnumerable<SearchResult> GetSerachResults(string searchQuery);
    }
}