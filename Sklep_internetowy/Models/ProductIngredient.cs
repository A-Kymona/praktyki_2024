namespace Sklep_internetowy.Models
{
    public class ProductIngredient
    {
        public int ProduktId { get; set; }
        public Product Product { get; set; }
        public int skladnikId { get; set; }
        public Ingredient Ingredient { get; set; }
    }
}