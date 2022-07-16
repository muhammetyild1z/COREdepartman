using CoreDepartman.Models;
using DotLiquid.Tags;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CoreDepartman.Controllers
{
    public class Personelim : Controller
    {
        
        Context c = new Context();
        [Authorize]
        public IActionResult Index()
        {
            return View(c.Personels.Include(x=> x.Birim).ToList());
        }
        [HttpGet]
        public IActionResult PersonelEkle()
        {
            List<SelectListItem> deger = new List<SelectListItem>();
            foreach (var item in c.Birims.ToList())
            {
                deger.Add(new SelectListItem { Text = item.BirimAD, Value = item.BirimID.ToString() });
            }
            ViewBag.dgr = deger;

            return View();
        }
    
        [HttpPost]
        public IActionResult PersonelEkle(Personel p)
        {
            var per = c.Birims.Where(x => x.BirimID == p.Birim.BirimID).FirstOrDefault();
            p.Birim = per;
            c.Personels.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult PersonelSil(int id)
        {
            var dep = c.Personels.Find(id);
            c.Personels.Remove(dep);
            c.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult PersonelGetir(int id)
        {
            var dep = c.Personels.Find(id);


            List<SelectListItem> degerr = new List<SelectListItem>();
            foreach (var item in c.Birims.ToList())
            {
                degerr.Add(new SelectListItem { Text = item.BirimAD, Value = item.BirimID.ToString() });
            }
            ViewBag.dgrr = degerr;

            return View("PersonelGetir", dep);

        }
        //    PERSONEL GÜNCELLEME ?????????????
        [HttpPost]
        public IActionResult PersonelGuncelle(int id ,Personel p )
        {

            var per = c.Personels.Find(p.PersonelID);
            var dpt = c.Personels.Include(x=> x.Birim).ToList();
            per.PersonelAD = p.PersonelAD;
            per.PersonelSoyad = p.PersonelSoyad;
            per.PersonelSehir = p.PersonelSehir;
            per.Birim.BirimAD = p.Birim.BirimAD;

            c.SaveChanges();

            return RedirectToAction("Index");


        }
    }
}

