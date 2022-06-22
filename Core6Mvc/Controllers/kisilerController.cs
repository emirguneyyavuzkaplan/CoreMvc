using Core6Mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace Core6Mvc.Controllers
{
    public class kisilerController : Controller
    {
        public IActionResult Index()
        {
            List<Kisi> Kisiler = new List<Kisi>()
            {
                new Kisi {Ad="Ali", Soyad="Kaya", Gsm="532"},
                new Kisi {Ad="Ayse", Soyad="Yilmaz", Gsm="533"},
                new Kisi {Ad="Veli", Soyad="Gezer", Gsm="534"},
                new Kisi {Ad="Fatma", Soyad="Kaya", Gsm="532"},

            };
            return View(Kisiler);
        }
    }
}
