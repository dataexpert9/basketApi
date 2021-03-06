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
    
    public partial class Offer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Offer()
        {
            this.Offer_Packages = new HashSet<Offer_Packages>();
            this.Offer_Products = new HashSet<Offer_Products>();
        }
    
        public int Id { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        public string ImageUrl { get; set; }
        public int Store_Id { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime ValidFrom { get; set; }
        public System.DateTime ValidUpto { get; set; }
        public string Name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Offer_Packages> Offer_Packages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Offer_Products> Offer_Products { get; set; }
        public virtual Store Store { get; set; }
    }
}
