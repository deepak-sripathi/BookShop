using System;
using System.Collections.Generic;

namespace BookShop.BuisnessLayer
{
    public class CartModel
    {
        public List<Product> products { get; set; }

        public decimal SubTotal { get; set; }

        public decimal Tax { get; set; }

        public decimal Discount{ get; set; }

        public decimal Total { get; set; }
    }
}
