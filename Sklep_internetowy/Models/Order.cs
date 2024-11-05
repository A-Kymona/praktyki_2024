namespace Sklep_internetowy.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public DateTime Czas_zamowienia { get; set; }
        public string? UserID { get; set; }
        public ApplicationUsers Urzytkownik { get; set; }
        public decimal Kwota_zamowienia { get; set; }
        public ICollection<OrderItem> Zamowiony_przedmiot { get; set; }
    }
}
