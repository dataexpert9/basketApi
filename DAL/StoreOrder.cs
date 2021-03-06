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
    
    public partial class StoreOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StoreOrder()
        {
            this.Order_Items = new HashSet<Order_Items>();
        }
    
        public int Id { get; set; }
        public string OrderNo { get; set; }
        public int Status { get; set; }
        public int Store_Id { get; set; }
        public double Subtotal { get; set; }
        public double Total { get; set; }
        public bool IsDeleted { get; set; }
        public int Order_Id { get; set; }
        public bool RemoveFromDelivererHistory { get; set; }
        public bool RemoveFromUserHistory { get; set; }
        public double DeliveryFee { get; set; }
        public double MinimumOrderPrice { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order_Items> Order_Items { get; set; }
        public virtual Order Order { get; set; }
        public virtual Store Store { get; set; }
    }
}
