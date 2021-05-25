using BookShop.BuisnessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.BuisnessLayer.Implementations
{
    public class CalculateTax : ICalculateTax
    {
        decimal ICalculateTax.CalculateTax(decimal subtotal)
        {
            return subtotal * 18 / 100;
        }
    }
}
