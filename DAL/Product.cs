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
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.Favourites = new HashSet<Favourite>();
            this.Offer_Products = new HashSet<Offer_Products>();
            this.Order_Items = new HashSet<Order_Items>();
            this.Package_Products = new HashSet<Package_Products>();
            this.ProductRatings = new HashSet<ProductRating>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string VideoUrl { get; set; }
        public short Status { get; set; }
        public int Category_Id { get; set; }
        public int Store_Id { get; set; }
        public string Size { get; set; }
        public bool IsDeleted { get; set; }
        public double WeightInGrams { get; set; }
        public double WeightInKiloGrams { get; set; }
        public int WeightUnit { get; set; }
        public int OrderedCount { get; set; }
        public double AverageRating { get; set; }
        public Nullable<double> WeightInMeters { get; set; }
        public Nullable<double> WeightInLiter { get; set; }
        public Nullable<double> WeightInMilliLiter { get; set; }
    
        public virtual Category Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Favourite> Favourites { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Offer_Products> Offer_Products { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order_Items> Order_Items { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Package_Products> Package_Products { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductRating> ProductRatings { get; set; }
        public virtual Store Store { get; set; }
    }
}