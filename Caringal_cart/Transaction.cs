//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Caringal_cart
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transaction
    {
        public Transaction()
        {
            this.TransDetails = new HashSet<TransDetail>();
        }
    
        public int trans_id { get; set; }
        public double total { get; set; }
    
        public virtual ICollection<TransDetail> TransDetails { get; set; }
    }
}