using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication2.Models
{
    public class AdminSettings
    {
        public string Language { get; set; }
        public string Avatar { get; set; }
        public string TimeZone { get; set; }
        public string CompanyLogo { get; set; }
        public bool SelfSignUpEnabled { get; set; }
        public bool SelfSignUpRestrictions { get; set; }
        public bool SelfSignUpValidDomains { get; set; }
        public bool SelfSignUpNotify { get; set; }
    }
}