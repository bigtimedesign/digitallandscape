//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WeWorkModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Company
    {
        public Company()
        {
            this.CompanyCategories = new HashSet<CompanyCategory>();
            this.PersonCompanies = new HashSet<PersonCompany>();
        }
    
        public int companyId { get; set; }
        public string name { get; set; }
        public string website { get; set; }
        public string jobsPageUrl { get; set; }
        public string address { get; set; }
        public string description { get; set; }
        public string tags { get; set; }
        public string technologies { get; set; }
        public string numberOfEmployees { get; set; }
        public string revenue { get; set; }
        public string logo { get; set; }
    
        public virtual ICollection<CompanyCategory> CompanyCategories { get; set; }
        public virtual ICollection<PersonCompany> PersonCompanies { get; set; }
    }
}
