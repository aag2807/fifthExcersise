using System;
using fifth_excersise.Enums;

namespace fifth_excersise.Entity
{
    public class Producto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Categories CategoryId { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public double Price { get; set; }

        public Producto(
            int id,
            string nombre,
            Categories categoria,
            string marca,
            string modelo,
            double precio
        )
        {
            this.Id = id;
            this.Name = nombre;
            this.CategoryId = categoria;
            this.Brand = marca;
            this.Model = modelo;
            this.Price = precio;
        }
    }
}
