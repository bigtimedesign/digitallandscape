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
    
    public partial class Project
    {
        public Project()
        {
            this.PersonProjects = new HashSet<PersonProject>();
        }
    
        public int projectId { get; set; }
        public string name { get; set; }
        public string website { get; set; }
        public string description { get; set; }
        public string tags { get; set; }
        public string technologies { get; set; }
        public string logo { get; set; }
    
        public virtual ICollection<PersonProject> PersonProjects { get; set; }
    }
}
