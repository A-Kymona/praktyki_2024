namespace Sklep_internetowy.Models
{
    public class OrderItem
    {
        public int OrderItemID { get; set; }
        public int ID_Zamowienie { get; set; }
        public Order? Zamowienie { get; set; }
        public int ProduktId { get; set; }
        public Product? Produkt { get; set; }
        public int Quantity { get; set; }
        public decimal Cena { get; set; }
    }
}