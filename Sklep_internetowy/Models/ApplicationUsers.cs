using Microsoft.AspNetCore.Identity;

namespace Sklep_internetowy.Models
{
    public class ApplicationUsers : IdentityUser
    {
        public ICollection<Order>? Zamówienia { get; set; }
    }
}
