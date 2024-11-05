using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sklep_internetowy.Models
{
    public class Product
    {
        public Product()
        {
            ProductIngredients = new List<ProductIngredient>();
        }
        public int ProductId { get; set; }
        public string? Nazwa { get; set; }
        public string? Opis { get; set; }
        public decimal Cena { get; set; }
        public int Ilosc { get; set; }
        public int Id_Kategoria { get; set; }

        [NotMapped]
        public IFormFile? Plik_zdj { get; set; }
        public string Url_zdj { get; set; } = "https://via.placeholder.com/150";

        [ValidateNever]
        public Category? Kategoria { get; set; } //A product belongs to a category
        
        [ValidateNever]
        public ICollection<OrderItem>? OrderItems { get; set; } //A product can be in many order items
        
        [ValidateNever]
        public ICollection<ProductIngredient>? ProductIngredients { get; set; } //A product can have many ingredients

    }
}