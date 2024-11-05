using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using Sklep_internetowy.Models;

namespace Sklep_internetowy.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUsers>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Produkty { get; set; }
        public DbSet<Category> Kategorie { get; set; }
        public DbSet<Order> Zamowienia { get; set; }
        public DbSet<OrderItem> PrzedmiotZamowienia { get; set; }
        public DbSet<Ingredient> Skladniki { get; set; }
        public DbSet<ProductIngredient> Skladniki_Zamowienia { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProductIngredient>()
                .HasKey(pi => new { pi.ProduktId, pi.Id_skladnik });

            modelBuilder.Entity<ProductIngredient>()
                .HasOne(pi => pi.Product)
                .WithMany(p => p.ProductIngredients)
                .HasForeignKey(p => p.ProduktId);

            modelBuilder.Entity<ProductIngredient>()
                .HasOne(pi => pi.Ingredient)
                .WithMany(i => i.skladniki_zamowienia)
                .HasForeignKey(pi => pi.Id_skladnik);

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Nazwa = "Zakąski" },
                new Category { CategoryId = 2, Nazwa = "Dania główne" },
                new Category { CategoryId = 3, Nazwa = "Przystawiki" },
                new Category { CategoryId = 4, Nazwa = "Desery" },
                new Category { CategoryId = 5, Nazwa = "Napoje" }
            );

            modelBuilder.Entity<Ingredient>().HasData(
                new Ingredient { IngredientId = 1, Nazwa = "Wołowina" },
                new Ingredient { IngredientId = 2, Nazwa = "Kurczak" },
                new Ingredient { IngredientId = 3, Nazwa = "Ryba" },
                new Ingredient { IngredientId = 4, Nazwa = "Tortilla" },
                new Ingredient { IngredientId = 5, Nazwa = "Sałata" },
                new Ingredient { IngredientId = 6, Nazwa = "Pomidor" },
                new Ingredient { IngredientId = 7, Nazwa = "Ogórek" },
                new Ingredient { IngredientId = 8, Nazwa = "Bułka" }

            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    Nazwa = "Taco z wołowiną",
                    Opis = "Smaczne taco z wołowiną",
                    Cena = 10.50m,
                    Ilosc = 100,
                    Id_Kategoria = 2
                },
                new Product
                {
                    ProductId = 2,
                    Nazwa = "Taco z kurczakiem",
                    Opis = "Smaczne taco z kurczakiem",
                    Cena = 8m,
                    Ilosc = 120,
                    Id_Kategoria = 2
                },
                new Product
                {
                    ProductId = 3,
                    Nazwa = "Taco z rybą",
                    Opis = "Smaczne taco z rybą",
                    Cena = 12.50m,
                    Ilosc = 300,
                    Id_Kategoria = 2
                },
                new Product
                {
                    ProductId = 4,
                    Nazwa = "Hamburger",
                    Opis = "Pyszny Hamburger z wołowiny",
                    Cena = 20.50m,
                    Ilosc = 50,
                    Id_Kategoria = 2
                }
                );

            modelBuilder.Entity<ProductIngredient>().HasData(
                //Taco z wołowiną
                new ProductIngredient {ProduktId =1, Id_skladnik=1},
                new ProductIngredient { ProduktId = 1, Id_skladnik = 4 },
                new ProductIngredient { ProduktId = 1, Id_skladnik = 5 },
                new ProductIngredient { ProduktId = 1, Id_skladnik = 6 },

                //Taco z kurczakiem
                new ProductIngredient { ProduktId = 2, Id_skladnik = 2 },
                new ProductIngredient { ProduktId = 2, Id_skladnik = 4 },
                new ProductIngredient { ProduktId = 2, Id_skladnik = 5 },
                new ProductIngredient { ProduktId = 2, Id_skladnik = 6 },

                //Taco z rybą
                new ProductIngredient { ProduktId = 3, Id_skladnik = 3 },
                new ProductIngredient { ProduktId = 3, Id_skladnik = 4 },
                new ProductIngredient { ProduktId = 3, Id_skladnik = 5 },
                new ProductIngredient { ProduktId = 3, Id_skladnik = 6 },

                new ProductIngredient { ProduktId = 4, Id_skladnik = 1 },
                new ProductIngredient { ProduktId = 4, Id_skladnik = 5 },
                new ProductIngredient { ProduktId = 4, Id_skladnik = 6 },
                new ProductIngredient { ProduktId = 4, Id_skladnik = 7 },
                new ProductIngredient { ProduktId = 4, Id_skladnik = 8 }

                );
        }
    }
}
