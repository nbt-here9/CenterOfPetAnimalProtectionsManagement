//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataProvider
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblAccount
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblAccount()
        {
            this.tblPet = new HashSet<tblPet>();
            this.tblPetDiary = new HashSet<tblPetDiary>();
        }
    
        public string username { get; set; }
        public string password { get; set; }
        public string fullname { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public bool isInBlackList { get; set; }
        public string reasonBlackList { get; set; }
        public int roleID { get; set; }
        public bool status { get; set; }
        public string image { get; set; }
    
        public virtual tblRole tblRole { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPet> tblPet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPetDiary> tblPetDiary { get; set; }
    }
}
