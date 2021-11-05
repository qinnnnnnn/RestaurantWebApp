﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantWebApp.ViewModels
{
    public class OrderDetailViewModel
    {
        public int OrderDetailID { get; set; }
        public int ProductID { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal Quantity { get; set; }
        public decimal FinalTotal { get; set; }      

    }
}