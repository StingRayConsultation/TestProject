//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApIJsonParser
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserPermission
    {
        public UserPermission()
        {
            this.Users = new HashSet<User>();
        }
    
        public int ID { get; set; }
        public string Role { get; set; }
        public Nullable<bool> ReadPer { get; set; }
        public Nullable<bool> InsPer { get; set; }
        public Nullable<bool> DelPer { get; set; }
    
        public virtual ICollection<User> Users { get; set; }
    }
}
