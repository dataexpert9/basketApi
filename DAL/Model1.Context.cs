﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BasketAppMLEntities : DbContext
    {
        public BasketAppMLEntities()
            : base("name=BasketAppMLEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AdminNotification> AdminNotifications { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<AdminSubAdminNotification> AdminSubAdminNotifications { get; set; }
        public virtual DbSet<Application> Applications { get; set; }
        public virtual DbSet<AppRating> AppRatings { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<ContactU> ContactUs { get; set; }
        public virtual DbSet<DelivererAddress> DelivererAddresses { get; set; }
        public virtual DbSet<DeliveryMan_AvailibilitySchedule> DeliveryMan_AvailibilitySchedule { get; set; }
        public virtual DbSet<DeliveryManRating> DeliveryManRatings { get; set; }
        public virtual DbSet<DeliveryMan> DeliveryMen { get; set; }
        public virtual DbSet<ErrorLog> ErrorLogs { get; set; }
        public virtual DbSet<Favourite> Favourites { get; set; }
        public virtual DbSet<ForgotPasswordToken> ForgotPasswordTokens { get; set; }
        public virtual DbSet<Franchisor> Franchisors { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<Offer_Packages> Offer_Packages { get; set; }
        public virtual DbSet<Offer_Products> Offer_Products { get; set; }
        public virtual DbSet<Offer> Offers { get; set; }
        public virtual DbSet<Order_Items> Order_Items { get; set; }
        public virtual DbSet<OrderPayment> OrderPayments { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Package_Products> Package_Products { get; set; }
        public virtual DbSet<Package> Packages { get; set; }
        public virtual DbSet<PaymentCard> PaymentCards { get; set; }
        public virtual DbSet<ProductRating> ProductRatings { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<RefreshToken> RefreshTokens { get; set; }
        public virtual DbSet<Setting> Settings { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<StoreDeliveryHour> StoreDeliveryHours { get; set; }
        public virtual DbSet<StoreOrder> StoreOrders { get; set; }
        public virtual DbSet<StorePayment> StorePayments { get; set; }
        public virtual DbSet<StoreRating> StoreRatings { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<UserAddress> UserAddresses { get; set; }
        public virtual DbSet<UserDevice> UserDevices { get; set; }
        public virtual DbSet<UserRating> UserRatings { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<VerifyNumberCode> VerifyNumberCodes { get; set; }
    }
}