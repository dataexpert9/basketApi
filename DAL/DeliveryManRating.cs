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
    
    public partial class DeliveryManRating
    {
        public int Id { get; set; }
        public short Rating { get; set; }
        public int User_ID { get; set; }
        public int Deliverer_Id { get; set; }
        public string Description { get; set; }
    
        public virtual DeliveryMan DeliveryMan { get; set; }
        public virtual User User { get; set; }
    }
}
