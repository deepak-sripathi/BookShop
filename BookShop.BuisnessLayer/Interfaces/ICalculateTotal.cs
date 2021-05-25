﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.BuisnessLayer.Interfaces
{
    interface ICalculateTotal
    {
        decimal GetTotal(decimal subtotal, decimal tax, decimal discount);
    }
}