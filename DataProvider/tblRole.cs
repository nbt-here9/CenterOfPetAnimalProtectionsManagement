//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataProvider
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblRole
    {
        public tblRole()
        {
            this.tblAccount = new HashSet<tblAccount>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
    
        public virtual ICollection<tblAccount> tblAccount { get; set; }
    }
}
