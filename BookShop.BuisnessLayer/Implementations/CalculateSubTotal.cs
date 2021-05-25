using BookShop.BuisnessLayer.Interfaces;
using System;
using System.Collections.Generic;

namespace BookShop.BuisnessLayer.Implementations
{
    public class CalculateSubTotal : ICalculateSubTotal
    {
        public decimal GetSubTotal(List<Product> products)
        {
            decimal subtotal = 0;
            
            foreach(Product product in products)
            {
                subtotal = subtotal + product.Amount;
            }
            return subtotal;
        }
    }
}
