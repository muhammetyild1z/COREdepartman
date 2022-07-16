using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreDepartman.Models;
using Microsoft.AspNetCore.Authorization;

namespace CoreDepartman.Controllers
{
    public class DefaultController : Controller
    {
        Context c = new Context();
        [Authorize]
        public IActionResult Index()
        {
           
            var deger = c.Birims.ToList();
            return View(deger);
        }

        [HttpGet]
        public IActionResult BirimEkle()
        {

            return View();
        }
        [HttpPost]
        public IActionResult BirimEkle(Birim d)
        {
            c.Birims.Add(d);
            c.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult BirimSil(int id)
        {
            var dep = c.Birims.Find(id);
            c.Birims.Remove(dep);
            c.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult BirimGetir(int id)
        {
            var dep = c.Birims.Find(id);

            return View("BirimGetir", dep);

        }
        [HttpPost]
        public IActionResult depGuncelle(int id , Birim b)
        {
            //var dpt = c.Birims.Where(x => x.BirimID == id).FirstOrDefault();
            //if (dpt!=null)
            //{
            //    dpt.BirimAD = b.BirimAD;
            //    c.SaveChanges();
            //    return RedirectToAction("Index");
            //}
           // b.BirimID = id;
            var dpt = c.Birims.Find(id);
            dpt.BirimAD = b.BirimAD;
            c.SaveChanges();

            return RedirectToAction("Index");


        }
        public IActionResult BirimDetay(int id)
        {
            var deger = c.Personels.Where(x => x.BirimID == id).ToList();
            var brmad = c.Birims.Where(x => x.BirimID == id).Select(y => y.BirimAD).FirstOrDefault();
            ViewBag.brm = brmad;
            return View(deger);
        }
    }
}
