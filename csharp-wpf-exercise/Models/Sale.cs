//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace csharp_wpf_exercise.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sale
    {
        public int SalesID { get; set; }
        public int SalesPersonID { get; set; }
        public int CustomerID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Product Product { get; set; }
    }
}
