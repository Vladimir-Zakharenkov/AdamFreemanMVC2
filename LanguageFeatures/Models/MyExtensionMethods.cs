
using System.Collections.Generic;

namespace LanguageFeatures.Models
{
    #region The Contents of the MyExtensionMethods.cs

    //public static class MyExtensionMethods
    //{
    //    public static decimal TotalPrices(this ShoppingCart cartParam)
    //    {
    //        decimal total = 0;

    //        foreach (Product prod in cartParam.Products)
    //        {
    //            total += prod?.Price ?? 0;
    //        }

    //        return total;
    //    }

    //}

    #endregion

    #region Updating an Extension Method

    //public static class MyExtansionMethod
    //{
    //    public static decimal TotalPrices(this IEnumerable<Product> products)
    //    {
    //        decimal total = 0;

    //        foreach (Product prod in products)
    //        {
    //            total += prod?.Price ?? 0;
    //        }

    //        return total;
    //    }
    //}

    #endregion

    #region Adding Filtering Extension Method

    public static class MyExtensionMethods
    {
        public static decimal TotalPrices(this IEnumerable<Product> products)
        {
            decimal total = 0;

            foreach (Product prod in products)
            {
                total += prod?.Price ?? 0;
            }
            return total;
        }
        public static IEnumerable<Product> FilterByPrice(this IEnumerable<Product> productEnum, decimal minimumPrice)
        {
            foreach (Product prod in productEnum)
            {
                if ((prod?.Price ?? 0) >= minimumPrice)
                {
                    yield return prod;
                }
            }
        }
    }

    #endregion

}

