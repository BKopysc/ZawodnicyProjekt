using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zawodnicy.WebApp.Controllers
{
    public class SecretController : Controller
    {
        //roles, authorize
        //na poziomie kontrollera i strony <widoku> !

        public IActionResult Index()
        {
            return View();
        }
    }
}
