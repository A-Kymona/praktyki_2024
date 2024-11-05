namespace Sklep_internetowy.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Nazwa { get; set; }
        public ICollection<Product> Produkty { get; set; }
    }
}