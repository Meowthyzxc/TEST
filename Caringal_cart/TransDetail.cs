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
    
    public partial class TransDetail
    {
        public int trans_details_id { get; set; }
        public int prod_id { get; set; }
        public int trans_id { get; set; }
        public double price { get; set; }
        public int qty { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual Transaction Transaction { get; set; }
    }
}
