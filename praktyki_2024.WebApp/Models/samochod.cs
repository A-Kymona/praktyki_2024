namespace praktyki_2024.WebApp.Models
{
    public class samochod
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Rok_produkcji { get; set; }
    
    public samochod() {
            Id = 1;
            Marka = "Opel";
            Model = "Meriva";
            Rok_produkcji = 2016;
        
        }
    
    }
}
