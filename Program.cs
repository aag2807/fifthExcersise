using System;
using System.Collections.Generic;
using System.Linq;
using fifth_excersise.Entity;
using fifth_excersise.Enums;
using fifth_excersise.Utils;
using fifth_excersise.Model;

namespace fifth_excersise
{
    class Program
    {
        static void Main(string[] args)
        {
            Data.GetCategories();
            List<Producto> PRODUCTS = Data.GetProducts();
            List<Categoria> CATEGORIES = Data.GetCategories();

            List<Producto> productsFilteredByCategory =
                PRODUCTS.GetProductsByCategory(Categories.Alimentos);
            /*
                for (int i = 0; i < productsFilteredByCategory.Count; i++)
                {
                    Console.WriteLine(productsFilteredByCategory[i].Name);
                }
            */

            List<Producto> productsFilteredInPriceRange =
                PRODUCTS.GetProductsByCategory(Categories.Vestimenta);

            /*
                for (int i = 0; i < productsFilteredByCategory.Count; i++)
                {
                    Console.WriteLine(productsFilteredByCategory[i].Price);
                }
            */
           
           List<ProductCategory> pairedProductsWithCategory =  PRODUCTS.MatchProductsWithCategory(CATEGORIES);
           /*
                for (int i = 0; i < pairedProductsWithCategory.Count; i++)
                {
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine(pairedProductsWithCategory[i].Name);
                    Console.WriteLine(pairedProductsWithCategory[i].Category);
                    Console.WriteLine("-----------------------------");
                }
            */
        }
    }
}
