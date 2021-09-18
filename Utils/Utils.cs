using System;
using System.Collections.Generic;
using System.Linq;
using fifth_excersise.Entity;
using fifth_excersise.Enums;
using fifth_excersise.Model;

namespace fifth_excersise.Utils
{
    public static class Utils
    {
        public static List<Producto>
        GetProductsByCategory(this List<Producto> products, Categories category)
        {
            return products.FindAll(prod => prod.CategoryId == category);
        }

        public static List<Producto>
        GetProductsBetweenRange(this List<Producto> products)
        {
            return products
                .FindAll(prod => prod.Price < 5000 && prod.Price > 3000);
        }

        public static  List<ProductCategory> MatchProductsWithCategory(
            this List<Producto> products,
            List<Categoria> categories
        )
        {
            var mapList = new List<ProductCategory>();

            var query =
                from p in products
                join c in categories on p.CategoryId equals c.Id
                select new ProductCategory(p.Name, c.Name);

            foreach (var item in query)
            {
                /*
                    var personsDump = ObjectDumper.Dump(item, DumpStyle.CSharp);
                    Console.WriteLine (personsDump);

                    var productCategory = new ProductCategory
                    {
                    Name = "Pimenton",
                    Category = "Alimentos"
                    };
                    var productCategory = new ProductCategory
                    {
                    Name = "Zanahoria",
                    Category = "Alimentos"
                    };
                    var productCategory = new ProductCategory
                    {
                    Name = "Polo Negra",
                    Category = "Vestimenta"
                    };
                    var productCategory = new ProductCategory
                    {
                    Name = "Zapatos Oxford",
                    Category = "Vestimenta"
                    };
                    var productCategory = new ProductCategory
                    {
                    Name = "Blue Jean",
                    Category = "Vestimenta"
                    };
                    var productCategory = new ProductCategory
                    {
                    Name = "yoTelefono",
                    Category = "Electrodomesticos"
                    };
                    var productCategory = new ProductCategory
                    {
                    Name = "Galaxia I7",
                    Category = "Electrodomesticos"
                    };
                    var productCategory = new ProductCategory
                    {
                    Name = "Cloro",
                    Category = "Limpieza"
                    };
                    var productCategory = new ProductCategory
                    {
                    Name = "Desinfectante",
                    Category = "Limpieza"
                    };
                    var productCategory = new ProductCategory
                    {
                    Name = "Isopropelic Alcohol",
                    Category = "Medico"
                    };
                    var productCategory = new ProductCategory
                    {
                    Name = "Gazas",
                    Category = "Medico"
                    };
                    var productCategory = new ProductCategory
                    {
                    Name = "White Rum",
                    Category = "Alimentos"
                    };
                */
                mapList.Add (item);
            }
            return mapList;
        }
    }
}
