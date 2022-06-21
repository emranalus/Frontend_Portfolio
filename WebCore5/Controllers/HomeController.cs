using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebCore5.Models;

namespace WebCore5.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            List<Kisi> kisiler = new List<Kisi>();
           
            Kisi ali= new Kisi { Ad="Ali", Soyad="Yilmaz", Gsm="532"};
            kisiler.Add(ali);

            Kisi ayse = new Kisi { Ad = "Ayse", Soyad = "Kaya", Gsm = "542" };
            kisiler.Add(ayse);

            Kisi fatma = new Kisi { Ad = "Fatma", Soyad = "Erturk", Gsm = "544" };
            kisiler.Add(fatma);

            return View(kisiler);
        }
        public IActionResult Hakkimizda()
        {
            return View();
        }

        public IActionResult Referanslar()
        {
            return View();
        }

    }
}
