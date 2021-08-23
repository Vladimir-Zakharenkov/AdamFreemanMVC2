using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    public class Product
    {
        #region Initial model

        //public string Name { get; set; }
        //public decimal? Price { get; set; }

        //public static Product[] GetProduct()
        //{
        //    Product kayak = new Product
        //    {
        //        Name = "Kayak",
        //        Price = 275M
        //    };

        //    Product lifejacket = new Product
        //    {
        //        Name = "Lifejacket",
        //        Price = 48.95M
        //    };

        //    return new Product[] { kayak, lifejacket, null };
        //}

        #endregion

        #region Adding a Property in the Product.cs File

        public string Name { get; set; }
        public decimal? Price { get; set; }
        public Product Related {  get; set; }

        public static Product[] GetProduct()
        {
            Product kayak = new Product
            {
                Name = "Kayak",
                Price = 275M
            };

            Product lifejacket = new Product
            {
                Name = "Lifejacket",
                Price = 48.95M
            };

            kayak.Related = lifejacket;

            return new Product[] { kayak, lifejacket, null };
        }

        #endregion

    }
}