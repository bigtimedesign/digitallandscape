using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;

using WeWorkModel;

namespace weWork.Models
{
    public class SummaryModel
    {
        public int CompanyCount { get; set; }
        public int GroupCount { get; set; }
        public int ProjectCount { get; set; }
        public int ResourcesCount { get; set; }
        public int PeopleCount { get; set; }
    }
}
