using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Zawodnicy.WebApp.Controllers
{
    public class SkiJumperController : Controller
    {
        public async Task<IActionResult> IndexAsync()
        {
            string _restpath = "htttp://localhost:5000/skijumper";

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(_restpath))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();

                }
            }
            return View();
        }
    }
}
