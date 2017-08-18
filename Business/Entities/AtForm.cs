using BbmUnderlakare.Business.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Core;

namespace BbmUnderlakare.Business.Entities
{
    public class AtForm : IAtForm
    {

        public AtForm(int id,
                      string name, 
                      string huvudman, 
                      string aTblockensLangd, 
                      string aTBlockTermin, 
                      string antalSokandeBlock, 
                      int ingangslon, 
                      bool lonEfter18Manader, 
                      int sTLon, 
                      string studiepott,
                      bool personalbostad, 
                      string hyresnivaTreaRok, 
                      string bostadsmarknad,
                      bool hjalpAttHittaBoende,
                      string introduktion,
                      string undervisning,
                      string handledareHuvudansvar,
                      string mentorHuvudhandledare,
                      bool ledarskapsutbildning,
                      bool betaldATStamma,
                      bool ensamPaNattjour,
                      bool sTTjansterErbjuds,
                      bool mojlighetTillVikariat,
                      string obesattaTjanster,
                      string upptagningsomrade,
                      XhtmlString ovrigt,
                      string kontaktperson
                      )
        {
            Id = id;
            Name = name;
            Huvudman = huvudman;
            ATblockensLangd = aTblockensLangd;
            ATBlockTermin = aTBlockTermin;
            AntalSokandeBlock = antalSokandeBlock;
            Ingangslon = ingangslon;
            LonEfter18Manader = lonEfter18Manader;
            STLon = sTLon;
            Studiepott = studiepott;
            Personalbostad = personalbostad;
            HyresnivaTreaRok = hyresnivaTreaRok;
            Bostadsmarknad = bostadsmarknad;
            HjalpAttHittaBoende = hjalpAttHittaBoende;
            Introduktion = introduktion;
            Undervisning = undervisning;
            HandledareHuvudansvar = handledareHuvudansvar;
            MentorHuvudhandledare = mentorHuvudhandledare;
            Ledarskapsutbildning = ledarskapsutbildning;
            BetaldATStamma = betaldATStamma;
            EnsamPaNattjour = ensamPaNattjour;
            STTjansterErbjuds = sTTjansterErbjuds;
            MojlighetTillVikariat = mojlighetTillVikariat;
            ObesattaTjanster = obesattaTjanster;
            Upptagningsomrade = upptagningsomrade;
            Ovrigt = ovrigt;
            Kontaktperson = kontaktperson;

        }

        public int Id
        {
            get;
        }
        public string Name
        {
            get;
        }

        public string Huvudman
        {
            get;
        }

        public string ATblockensLangd
        {
            get;
        }

        public string ATBlockTermin
        {
            get;
        }

        public string AntalSokandeBlock
        {
            get;
        }

        public int Ingangslon
        {
            get;

        }

        public bool LonEfter18Manader
        {
            get;
        }

        public int STLon
        {
            get;
        }

        public string Studiepott
        {
            get;
        }

        public bool Personalbostad
        {
            get;
        }

        public string HyresnivaTreaRok
        {
            get;
        }

        public string Bostadsmarknad
        {
            get;
        }

        public bool HjalpAttHittaBoende
        {
            get;
        }

        public string Introduktion
        {
            get;
        }

        public string Undervisning
        {
            get;
        }

        public string HandledareHuvudansvar
        {
            get;
        }

        public string MentorHuvudhandledare
        {
            get;
        }

        public bool Ledarskapsutbildning
        {
            get;
        }

        public bool BetaldATStamma
        {
            get;
        }

        public bool EnsamPaNattjour
        {
            get;
        }

        public bool STTjansterErbjuds
        {
            get;
        }

        public bool MojlighetTillVikariat
        {
            get;
        }

        public string ObesattaTjanster
        {
            get;
        }

        public string Upptagningsomrade
        {
            get;
        }

        public XhtmlString Ovrigt
        {
            get;
        }

        public string Kontaktperson
        {
            get;
        }

    }
}