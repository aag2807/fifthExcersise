using fifth_excersise.Enums;

namespace fifth_excersise.Entity
{
    public class Categoria
    {
        public Categories Id { get; set; }

        public string Name { get; set; }

        public Categoria(Categories id, string nombre)
        {
            this.Id = id;
            this.Name = nombre;
        }
    }
}
