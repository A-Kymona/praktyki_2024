using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Sklep_internetowy.Data;
using Sklep_internetowy.Models;

namespace Sklep_internetowy.Controllers
{
    public class OrderController : Controller
    {
    
        private readonly ApplicationDbContext _context;
        private Repository<Product> _products;
        private Repository<Order> _orders;
        private readonly UserManager<ApplicationUsers> _userManager;

        public OrderController(ApplicationDbContext context, UserManager<ApplicationUsers> userManager)
        {
            _context = context;
            _userManager = userManager;
            _products = new Repository<Product>(context);
            _orders = new Repository<Order>(context);
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var model = HttpContext.Session.Get<OrderViewModel>("OrderViewModel") ?? new OrderViewModel
            {
                Zamowione_produkty = new List<OrderItemViewModel>(),
                Produkty = await _products.GetAllAsync()
            };


            return View(model);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddItem(int prodId, int prodQty)
        {
            var product = await _context.Produkty.FindAsync(prodId);
            if (product == null)
            {
                return NotFound();
            }

            // Retrieve or create an OrderViewModel from session or other state management
            var model = HttpContext.Session.Get<OrderViewModel>("OrderViewModel") ?? new OrderViewModel
            {
                Zamowione_produkty = new List<OrderItemViewModel>(),
                Produkty = await _products.GetAllAsync()
            };

            // Check if the product is already in the order
            var existingItem = model.Zamowione_produkty.FirstOrDefault(oi => oi.Id_produktu == prodId);

            // If the product is already in the order, update the quantity
            if (existingItem != null)
            {
                existingItem.Ilosc += prodQty;
            }
            else
            {
                model.Zamowione_produkty.Add(new OrderItemViewModel
                {
                    Id_produktu = product.ProductId,
                    Cena = product.Cena,
                    Ilosc = prodQty,
                    Nazwa_produktu = product.Nazwa
                });
            }

            model.Kwota_całkowita = model.Zamowione_produkty.Sum(oi => oi.Cena * oi.Ilosc);

            HttpContext.Session.Set("OrderViewModel", model);

            return RedirectToAction("Create", model);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Cart()
        {

            // Retrieve the OrderViewModel from session or other state management
            var model = HttpContext.Session.Get<OrderViewModel>("OrderViewModel");

            if (model == null || model.Zamowione_produkty.Count == 0)
            {
                return RedirectToAction("Create");
            }

            return View(model);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> PlaceOrder()
        {
            var model = HttpContext.Session.Get<OrderViewModel>("OrderViewModel");
            if (model == null || model.Zamowione_produkty.Count == 0)
            {
                return RedirectToAction("Create");
            }

            Order order = new Order
            {
                Czas_zamowienia = DateTime.Now,
                Kwota_zamowienia = model.Kwota_całkowita,
                UserID = _userManager.GetUserId(User)
            };

            foreach (var item in model.Zamowione_produkty)
            {
                order.Zamowiony_przedmiot.Add(new OrderItem
                {
                    ProduktId= item.Id_produktu,
                    Quantity = item.Ilosc,
                    Cena = item.Cena,
                });
            }

            await _orders.AddAsync(order);

            HttpContext.Session.Remove("OrderViewModel");

            return RedirectToAction("ViewOrders");
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> ViewOrders()
        {
            var userId = _userManager.GetUserId(User);

            var userOrders = await _orders.GetAllByIdAsync(userId, "UserId", new QueryOptions<Order>
            {
                Includes = "Zamowione_produkty.Product"
            });

            return View(userOrders);
        }



    }
}
