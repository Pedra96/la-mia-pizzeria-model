using La_Mia_Pizzeria_1.Models;
using La_Mia_Pizzeria_1.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace La_Mia_Pizzeria_1.Controllers {
    public class PizzaController : Controller {
        public IActionResult Index() {
            List<Pizza> listaDellePizze = PizzaData.GetPizzas();

            return View("Index", listaDellePizze);
        }
    }
}
