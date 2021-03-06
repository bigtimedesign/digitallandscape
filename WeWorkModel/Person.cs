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
    
    public partial class Person
    {
        public Person()
        {
            this.PersonCompanies = new HashSet<PersonCompany>();
            this.PersonGroups = new HashSet<PersonGroup>();
            this.PersonProjects = new HashSet<PersonProject>();
        }
    
        public int personId { get; set; }
        public string name { get; set; }
        public string location { get; set; }
        public string website { get; set; }
        public string bio { get; set; }
        public string tags { get; set; }
        public string technologies { get; set; }
        public string photo { get; set; }
        public string token { get; set; }
    
        public virtual ICollection<PersonCompany> PersonCompanies { get; set; }
        public virtual ICollection<PersonGroup> PersonGroups { get; set; }
        public virtual ICollection<PersonProject> PersonProjects { get; set; }
    }
}
