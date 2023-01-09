using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace La_Mia_Pizzeria_1.Controllers {
    public class PizzaController : Controller {
        public IActionResult Index() {
            List<Pizza> listaDeiPost = PostData.GetPosts();

            return View("Index", listaDeiPost);
            return View();
        }
    }
}
