//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Package_Products
    {
        public int Id { get; set; }
        public int Qty { get; set; }
        public int Product_Id { get; set; }
        public int Package_Id { get; set; }
    
        public virtual Package Package { get; set; }
        public virtual Product Product { get; set; }
    }
}
