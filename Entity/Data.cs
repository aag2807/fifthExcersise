using System;
using System.Collections.Generic;
using fifth_excersise.Enums;

namespace fifth_excersise.Entity
{
    public class Data
    {
        public static List<Categoria> GetCategories()
        {
            var CategoriesList =
                new List<Categoria>()
                {
                    new Categoria(Categories.Alimentos, "Alimentos"),
                    new Categoria(Categories.Vestimenta, "Vestimenta"),
                    new Categoria(Categories.Electrodomesticos,
                        "Electrodomesticos"),
                    new Categoria(Categories.Limpieza, "Limpieza"),
                    new Categoria(Categories.Medico, "Medico")
                };
            return CategoriesList;
        }

        public static List<Producto> GetProducts()
        {
            var productsList =
                new List<Producto>()
                {
                    new Producto(1,
                        "Pimenton",
                        Categories.Alimentos,
                        "comida enteras",
                        "Comestible",
                        50),
                    new Producto(2,
                        "Zanahoria",
                        Categories.Alimentos,
                        "super comida",
                        "Comestible",
                        4500),
                    new Producto(3,
                        "Polo Negra",
                        Categories.Vestimenta,
                        "Boutique",
                        "Polo shirt",
                        3420),
                    new Producto(4,
                        "Zapatos Oxford",
                        Categories.Vestimenta,
                        "Oxford",
                        "Zapatos",
                        20000),
                    new Producto(5,
                        "Blue Jean",
                        Categories.Vestimenta,
                        "Boutique",
                        "Jeans",
                        3000),
                    new Producto(6,
                        "yoTelefono",
                        Categories.Electrodomesticos,
                        "Manzana",
                        "Telefonos",
                       60000),
                    new Producto(7,
                        "Galaxia I7",
                        Categories.Electrodomesticos,
                        "Sung-Sam",
                        "Telefonos",
                        48500),
                    new Producto(8,
                        "Cloro",
                        Categories.Limpieza,
                        "CleanMore",
                        "Liquidos de Limpieza",
                        340),
                    new Producto(9,
                        "Desinfectante",
                        Categories.Limpieza,
                        "Cruz azul",
                        "Liquidos de Limpieza",
                       560),
                    new Producto(10,
                        "Isopropelic Alcohol",
                        Categories.Medico,
                        "medicos",
                        "Comestible",
                        3275),
                    new Producto(11,
                        "Gazas",
                        Categories.Medico,
                        "Cruz azul",
                        "medicos",
                        11000),
                    new Producto(12,
                        "White Rum",
                        Categories.Alimentos,
                        "super comida",
                        "Comestible",
                        5000)
                };
            return productsList;
        }
    }
}
