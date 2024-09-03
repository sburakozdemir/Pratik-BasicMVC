using Microsoft.AspNetCore.Mvc;
using Pratik_BasicMVC.Models;

namespace Pratik_BasicMVC.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            var customer = new Customer
            {
                Id = 1,
                FirstName = "Ali",
                LastName = "Veli",
                Email = "Aliveli@gmail.com"
            };

            var orderList = new List<Order>
            {
                new Order { Id = 1, ProductName = "Kitap", Price = 100, Quantity = 50 },
                new Order { Id = 2, ProductName = "Şampuan", Price = 80, Quantity = 500 },
                new Order { Id = 3, ProductName = "Kulaklık", Price = 8500, Quantity = 30 },
                new Order { Id = 4, ProductName = "Kahve", Price = 78, Quantity = 1000 }
            };

            var viewModel = new CustomerOrderViewModel
            {
                Customer = customer,
                Orders = orderList,
            };

            return View(viewModel); // View'e viewModel gönderildi
        }
    }
}
