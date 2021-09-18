namespace fifth_excersise.Model
{
    public class ProductCategory
    {
        public string Name { get; set; }

        public string Category { get; set; }

        public ProductCategory(string nombre, string categoria)
        {
            this.Name = nombre;
            this.Category = categoria;
        }
    }
}
