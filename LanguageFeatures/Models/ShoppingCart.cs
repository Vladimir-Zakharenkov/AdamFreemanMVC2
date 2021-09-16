using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    #region Make ShoppingCart.cs

    //public class ShoppingCart
    //{
    //    public IEnumerable<Product> Products { get; set; }
    //}

    #endregion

    #region Implementing an Interface

    public class ShoppingCart : IEnumerable<Product>
    {
        public IEnumerable<Product> Products { get; set; }

        public IEnumerator<Product> GetEnumerator() => Products.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    #endregion
}
