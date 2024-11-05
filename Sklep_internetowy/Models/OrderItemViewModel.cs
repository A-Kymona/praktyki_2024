namespace Sklep_internetowy.Models
{
    public class OrderItemViewModel
    {
        public int Id_produktu { get; set; }
        public string Nazwa_produktu { get; set; }
        public int Ilosc { get; set; }
        public decimal Cena { get; set; } // Price per unit
    }
}
