﻿using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;

namespace ShoppingCartMVC.Models
{
    public class dbOnlineStoreEntities : DbContext
    {
        public dbOnlineStoreEntities() : base("name=dbOnlineStoreEntities")
        {
        }

       
        public virtual DbSet<tblCategory> tblCategories { get; set; }
        public virtual DbSet<tblInvoice> tblInvoices { get; set; }
        public virtual DbSet<tblOrder> tblOrders { get; set; }
        public virtual DbSet<tblProduct> tblProducts { get; set; }
        public virtual DbSet<tblUser> tblUsers { get; set; }
      
    }
}

