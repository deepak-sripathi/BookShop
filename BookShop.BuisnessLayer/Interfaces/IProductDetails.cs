﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.BuisnessLayer.Interfaces
{
   public interface IProductDetails

    {
        List<Product> GetProducts();
    }
}
