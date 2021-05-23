using BookShop.BuisnessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.BuisnessLayer.Implementations
{
    public class ProductDetails : IProductDetails
    {
        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>
            {
                new Product
                {
                    Name="Wings of Fire",
                    Amount =270M,
                },
                new Product
                {
                    Name="Life ",
                    Amount=300M,
                },
                new Product
                {
                    Name="The girl in room 109",
                    Amount=200M,
                },
                 new Product
                {
                    Name="Think like a monk",
                    Amount =270M,
                },
                new Product
                {
                    Name="Thinking fast",
                    Amount=300M,
                },
                new Product
                {
                    Name="The perfect us",
                    Amount=200M,
                }
            };
            return products;
        }
    }
}
