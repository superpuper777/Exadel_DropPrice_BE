﻿using System;
using System.Collections.Generic;

namespace WebApi.ViewModels
{
    public class DiscountViewModel
    {
        public string VendorName { get; set; }

        public string DiscountName { get; set; }

        public string Description { get; set; }

        public int DiscountAmount { get; set; }

        public string PromoCode { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool ActivityStatus { get; set; }

        public string[] Tags { get; set; }

        public PointOfSaleViewModel[] PointOfSales { get; set; }
    }
}
