using EPiServer.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BbmUnderlakare.Business.Entities.Interfaces
{
    public interface IAtForm
    {
        int Id { get; }
        string Name { get; }
        string Huvudman { get; }
        string ATblockensLangd { get; }
        string ATBlockTermin { get; }
        string AntalSokandeBlock { get; }
        int Ingangslon { get; }
        bool LonEfter18Manader { get; }
        int STLon { get; }
        string Studiepott { get; }
        bool Personalbostad { get; }
        string HyresnivaTreaRok { get; }
        string Bostadsmarknad { get; }
        bool HjalpAttHittaBoende { get; }
        string Introduktion { get; }
        string Undervisning { get; }
        string HandledareHuvudansvar { get; }
        string MentorHuvudhandledare { get; }
        bool Ledarskapsutbildning { get; }
        bool BetaldATStamma { get; }
        bool EnsamPaNattjour { get; }
        bool STTjansterErbjuds { get; }
        bool MojlighetTillVikariat { get; }
        string ObesattaTjanster { get; }
        string Upptagningsomrade { get; }
        XhtmlString Ovrigt { get; }
        string Kontaktperson { get; }

    }
}