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
    
    public partial class PersonCompany
    {
        public int personCompanyId { get; set; }
        public int personId { get; set; }
        public int companyId { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual Person Person { get; set; }
    }
}
