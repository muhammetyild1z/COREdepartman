using CoreDepartman.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoreDepartman.Controllers
{
    public class LoginController : Controller
    {
        Context c = new Context();
        [HttpGet]
        public IActionResult GirisYap()
        {
            return View();
        }
      
        public async Task<IActionResult>  GirisYap(Admin a)
        {
            var bilgi = c.Admins.FirstOrDefault(x=> x.Kullanici==a.Kullanici && x.sifre==a.sifre);
            if (bilgi != null)
            {
                var claims = new List<Claim>
                {
                    new Claim (ClaimTypes.Name,a.Kullanici)
                };
                var identity = new ClaimsIdentity(claims,"Login");
                ClaimsPrincipal cP = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync(cP);
                return RedirectToAction("Index", "Personelim");

            }
            return View();
        }

    }
}
