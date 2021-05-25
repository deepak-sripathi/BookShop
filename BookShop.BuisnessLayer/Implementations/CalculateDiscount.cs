using BookShop.BuisnessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.BuisnessLayer.Implementations
{
    public class CalculateDiscount : ICalculateDiscount
    {
        public decimal GetDiscount(decimal subtotal)
        {
            decimal discount = 0;
            if (subtotal < 10000)
            {
                discount = subtotal * 20 / 100;
            }
            else if (subtotal >= 10000 && subtotal <= 15000)
            {
                discount = subtotal * 15 / 100;
            }
            else
            {
                discount = subtotal * 10 / 100;
            }
            return discount;
        }
    }
}
