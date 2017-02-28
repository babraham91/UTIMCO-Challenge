using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.Net.Http.Headers;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UTIMCOMenu.Models;
using UTIMCOMenu.BLL;

namespace UTIMCOMenu.Controllers
{
    public class MenuController : Controller
    {
        private readonly IMenuBLL _menuBLL;

        public MenuController(IMenuBLL menuBLL)
        {
            _menuBLL = menuBLL;
        }

        public IActionResult Upload()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Upload(IFormFile file)
        {
            List<MenuJson> menus = new List<MenuJson> { };
            SumsModel sums = new SumsModel { };

            using (StreamReader r = new StreamReader(file.OpenReadStream()))
            {
                string json = r.ReadToEnd();
                menus = JsonConvert.DeserializeObject<List<MenuJson>>(json);
            }

            sums = _menuBLL.Calculate(menus);

            return View(sums);
        }
    }
}
