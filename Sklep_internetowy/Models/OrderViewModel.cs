namespace Sklep_internetowy.Models
{
    public class OrderViewModel
    {

        public decimal Kwota_całkowita { get; set; }
        public List<OrderItemViewModel> Zamowione_produkty { get; set; }

        public IEnumerable<Product> Produkty { get; set; }
    }
}