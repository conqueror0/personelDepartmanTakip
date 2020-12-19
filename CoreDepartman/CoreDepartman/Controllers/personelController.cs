using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreDepartman.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CoreDepartman.Controllers
{
    public class personelController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.personals.Include(x=>x.departmanlar).ToList();
            return View(degerler);
        }

        [HttpGet]
        public IActionResult YeniPersonel()
        {
            List<SelectListItem> degerler = (from x in c.departmanlars.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.departmanAd,
                                                 Value = x.id.ToString()
                                             }).ToList();
            ViewBag.dgr = degerler;
            return View();
        }

        
        public IActionResult YeniPersonel(personal p)
        {
            var per = c.departmanlars.Where(x => x.id == p.departmanlar.id).FirstOrDefault();
            p.departmanlar = per;
            c.personals.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult PersonelSil(int id)
        {
            var dep = c.personals.Find(id);
            c.personals.Remove(dep);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult PersonelGetir(int id)
        {
            List<SelectListItem> degerler = (from x in c.departmanlars.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.departmanAd,
                                                 Value = x.id.ToString()
                                             }).ToList();
            ViewBag.dgr = degerler;
            var personel = c.personals.Find(id);
            return View("PersonelGetir", personel);
        }


        [HttpGet]
        public IActionResult PersonelGuncelle()
        {
            List<SelectListItem> degerler = (from x in c.departmanlars.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.departmanAd,
                                                 Value = x.id.ToString()
                                             }).ToList();
            ViewBag.dgr = degerler;
            return View();
        }
        public IActionResult PersonelGuncelle(personal d)
        {
            var per = c.personals.Find(d.perid);
            per.ad = d.ad;
            per.soyad = d.soyad;
            per.şehir = d.şehir;
            per.departmanlar.id = d.departmanlar.id;
            //per.departmanlar.id = c.departmanlars.Where(x => x.id == d.departmanlar.id).FirstOrDefault();
            per.iseGirisTarihi = d.iseGirisTarihi;
            per.yillikizinhakki = d.yillikizinhakki;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult PersonelİzinGetir(int id)
        {

            var personel = c.personals.Find(id);
            return View("PersonelİzinGetir", personel);
        }

        public IActionResult PersonelİzinGuncelle(personal d)
        {
            var dep = c.personals.Find(d.perid);
            dep.iseGirisTarihi = d.iseGirisTarihi;
            dep.yillikizinhakki = d.yillikizinhakki;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}