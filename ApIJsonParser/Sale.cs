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
    
    public partial class Sale
    {
        public int ID { get; set; }
        public Nullable<int> OrderID { get; set; }
        public Nullable<System.DateTime> PurchaseDate { get; set; }
    
        public virtual BoookOrder BoookOrder { get; set; }
    }
}
