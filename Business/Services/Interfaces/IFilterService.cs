using BbmUnderlakare.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BbmUnderlakare.Business.Services.Interfaces
{
    public interface IFilterService
    {
        IEnumerable<AtForm> FilterHospital(int ingangsLon, int sTLon, bool ensamPaNattjour, bool betaldAtStamma, bool ledarskapsutbildning, bool personalbostad, bool hjalpAttHittaBoende, bool mojlighetTillVikariat, bool sTTjansterErbjuds);
    }
}