﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace P00196754_Md_Nawaz_Sharif_Nahid_ExpenseTracker
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class expenseTrackerDBEntities1 : DbContext
    {
        public expenseTrackerDBEntities1()
            : base("name=expenseTrackerDBEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblCustomer> tblCustomers { get; set; }
        public virtual DbSet<tblExpenseCategory> tblExpenseCategories { get; set; }
        public virtual DbSet<tblExpenseItem> tblExpenseItems { get; set; }
        public virtual DbSet<tblExpenseRecord> tblExpenseRecords { get; set; }
        public virtual DbSet<tblMonth> tblMonths { get; set; }
        public virtual DbSet<tblPaymentType> tblPaymentTypes { get; set; }
        public virtual DbSet<tblUser> tblUsers { get; set; }
    }
}