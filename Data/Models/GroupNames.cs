using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BbmUnderlakare.Data.Models
{
    public static class GroupNames
    {
        [GroupDefinitions]
        public static class Content
        {
            [Display(Order = 10)]
            public const string GeneralContent = "General";

            [Display(Order = 20)]
            public const string GlobalBlocks = "Global";

            [Display(Order = 30)]
            public const string SpecialPages = "Special";

            [Display(Order = 40)]
            public const string LocalBlocks = "Local";

            [Display(Order = 50)]
            public const string SettingsBlocks = "Settings";
        }

        /// <summary>
        ///     Defines the names of the tab group names that are available througout the solution.
        ///     Note that these are localized through the lang file NetR.EPi.xx.xml
        /// </summary>
        [GroupDefinitions]
        public static class Tabs
        {
            [Display(Order = 10)]
            [RequiredAccess(AccessLevel.Edit)]
            public const string Content = SystemTabNames.Content;

            [Display(Order = 12)]
            [RequiredAccess(AccessLevel.Edit)]
            public const string Categories = "Categories";

            [Display(Order = 14)]
            [RequiredAccess(AccessLevel.Edit)]
            public const string TeaserInformation = "TeaserInformation";

            [Display(Order = 16)]
            [RequiredAccess(AccessLevel.Edit)]
            public const string SubNavigation = "SubNavigation";

            [Display(Order = 18)]
            [RequiredAccess(AccessLevel.Edit)]
            public const string Seo = "SEO";

            [Display(Order = 20)]
            [RequiredAccess(AccessLevel.Administer)]
            public const string Settings = SystemTabNames.Settings;

            [Display(Order = 25)]
            [RequiredAccess(AccessLevel.Edit)]
            public const string Navigation = "Navigation";

            [Display(Order = 27)]
            [RequiredAccess(AccessLevel.Edit)]
            public const string RightColumn = "RightColumn";

            [Display(Order = 26)]
            [RequiredAccess(AccessLevel.Edit)]
            public const string MiddleColumn = "MiddleColumn";


            [Display(Order = 30)]
            [RequiredAccess(AccessLevel.Edit)]
            public const string Form = "Form";

            [Display(Order = 35)]
            [RequiredAccess(AccessLevel.Edit)]
            public const string Event = "Event";

            [Display(Order = 36)]
            [RequiredAccess(AccessLevel.Edit)]
            public const string EventNetwork = "Event - Nätverk";

            [Display(Order = 37)]
            [RequiredAccess(AccessLevel.Edit)]
            public const string EventSeminar = "Event - Seminarium";

            [Display(Order = 38)]
            [RequiredAccess(AccessLevel.Edit)]
            public const string EventCourse = "Event - Kurser";

            [Display(Order = 39)]
            [RequiredAccess(AccessLevel.Edit)]
            public const string Jobs = "Lediga jobb";

            [Display(Order = 40)]
            [RequiredAccess(AccessLevel.Administer)]
            public const string Header = "Header";

            [Display(Order = 50)]
            [RequiredAccess(AccessLevel.Administer)]
            public const string Footer = "Footer";

            [Display(Order = 60)]
            [RequiredAccess(AccessLevel.Administer)]
            public const string SiteSettings = "SiteSettings";

            [Display(Order = 63)]
            [RequiredAccess(AccessLevel.Edit)]
            public const string Program = "Program";

            [Display(Order = 65)]
            [RequiredAccess(AccessLevel.Administer)]
            public const string Translations = "Translations";

            [Display(Order = 70)]
            [RequiredAccess(AccessLevel.Administer)]
            public const string Ads = "Ads";

            [Display(Order = 80)]
            [RequiredAccess(AccessLevel.Administer)]
            public const string Upsales = "Upsales";

            [Display(Order = 90)]
            [RequiredAccess(AccessLevel.Administer)]
            public const string Email = "Email";

            [Display(Order = 100)]
            [RequiredAccess(AccessLevel.Administer)]
            public const string Buying = "Köp";

            [Display(Order = 1000)]
            [RequiredAccess(AccessLevel.Administer)]
            public const string Import = "Import";

            // This is not a tab, but rather the settings panel that shows
            // up when you scroll up at the top of a page in edit mode.
            [Display]
            public const string PageHeader = SystemTabNames.PageHeader;
        }

        /// <summary>
        /// Defines the names of tab groups intended to use in the site settings block.
        /// </summary>
        public static class SettingsTabs
        {
            [Display(Order = 10)]
            public const string General = "GeneralSettings";
        }

        public static class UIHints
        {
            public const string ScheduleItems = "ScheduleItems";
            public const string Authors = "AuthorList";
            public const string TranslationItems = "TranslationItems";
            public const string EventAttendeeOption = "EventAttendeeOption";
        }
    }
}
