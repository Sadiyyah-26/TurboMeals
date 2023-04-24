﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ShoppingCartMVC.Models
{
    public partial class tblProduct
    {
        public tblProduct()
        {
            this.tblOrders = new HashSet<tblOrder>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Unit { get; set; }
        public string Image { get; set; }
        public int? CatId { get; set; }

        public virtual tblCategory tblCategory { get; set; }
        public virtual ICollection<tblOrder> tblOrders { get; set; }
    }
}