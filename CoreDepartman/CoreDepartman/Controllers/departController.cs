using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreDepartman.Models;

namespace CoreDepartman.Controllers
{
    public class departController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.departmanlars.ToList();
            return View(degerler);
        }

        [HttpGet]
        public IActionResult YeniDepartman()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YeniDepartman(departmanlar d)
        {
            c.departmanlars.Add(d);
            c.SaveChanges();
            //index actionuna yönlendir
            return RedirectToAction("Index");
        }

        public IActionResult DepartmanSil(int id)
        {
            var dep = c.departmanlars.Find(id);
            c.departmanlars.Remove(dep);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DepartmanGetir(int id)
        {
            var depart = c.departmanlars.Find(id);
            return View("DepartmanGetir",depart);
        }

        public IActionResult DepartmanGuncelle(departmanlar d)
        {
            var dep = c.departmanlars.Find(d.id);
            dep.departmanAd = d.departmanAd;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult BirimDetay(int id)
        {
            var degerler = c.personals.Where(x => x.departmanlar.id == id).ToList();
            var brmad = c.departmanlars.Where(x => x.id == id).Select(y => y.departmanAd).FirstOrDefault();
            ViewBag.brm = brmad;
            return View(degerler);
        }

        public IActionResult Hakkımızda()
        {
            return View();
        }
    }
}