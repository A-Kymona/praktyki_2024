using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Sklep_internetowy.Models
{
    public class Ingredient
    {
        public int IngredientId { get; set; }
        public string Nazwa { get; set; }

        [ValidateNever]
        public ICollection<ProductIngredient> skladniki_zamowienia { get; set; }
    }
}