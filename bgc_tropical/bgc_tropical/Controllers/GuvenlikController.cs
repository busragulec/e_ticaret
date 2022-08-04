using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.Security;
using bgc_tropical.Models.Class;

namespace bgc_tropical.Controllers
{
    public class GuvenlikController : Controller
    {
        Context db = new Context();
        // GET: Guvenlik
        public ActionResult GirisYap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GirisYap(register t)
        {
            var bilgiler = db.registers.FirstOrDefault(x => x.mail == t.mail && x.sifre == t.sifre);
            if (bilgiler != null)
            {

                FormsAuthentication.SetAuthCookie(bilgiler.mail, false);
                return RedirectToAction("Index", "AnaSayfa");

            }
            else
            {
                ViewBag.uyari = "E-posta adresiniz ve/veya şifreniz hatalı.!";

            }
            return View();
        }

        //public ActionResult SifremiUnuttum()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public ActionResult SifremiUnuttum(string eposta, register r)
        //{
        //    var magaza = db.registers.Where(m => m.mail == eposta).SingleOrDefault();
        //    if (magaza != null)
        //    {
        //        Random rnd = new Random();
        //        int kod = rnd.Next();

        //        register sifre = new register();
        //        sifre.id = magaza.id;
        //        sifre.mail = eposta;
        //        sifre.Tarih = DateTime.Now;
        //        sifre.kod = kod;
        //        db.registers.Add(sifre);
        //        db.SaveChanges();

        //        WebMail.SmtpServer = "smtp.gmail.com";
        //        WebMail.EnableSsl = true;
        //        WebMail.UserName = "bbguulec@gmail.com";
        //        WebMail.Password = "Busra2000";
        //        WebMail.SmtpPort = 587;
        //        WebMail.Send(eposta,"Şifre Yenileme Doğrulama Kodu", "Doğrulama Kodunuz : " + kod);

        //        ViewBag.uyari = "Doğrulama kodu mail adresinize gönderildi.";
        //        Response.Redirect("/Guvenlik/SifremiYenile/" + sifre.id);
        //    }
        //    else
        //    {
        //        ViewBag.uyari = "Bir hata oluştu. Tekrar Deneyiniz!";
        //    }
           
        //    return View();
        //}
        //public ActionResult SifremiYenile()
        //{
            
        //    return View();
        //}
        //[HttpPost]
        //public ActionResult SifremiYenile(string eposta, register mg, int sifre, int kod)
        //{
        //    var sifreunutan = db.registers.Where(s => s.mail == eposta).OrderByDescending(s => s.id).FirstOrDefault();
        //    var magaza = db.registers.Where(m => m.mail == eposta).SingleOrDefault();

        //    if (magaza != null && sifreunutan.kod == kod)
        //    {

        //        magaza.sifre = sifre.ToString();
        //        magaza.sifretekrar = sifre.ToString();
        //        db.SaveChanges();
        //        ViewBag.uyari = "Şifre Değişimi Sağlandı! Giriş Yapabilirsiniz.";
        //    }
        //    else
        //    {
        //        ViewBag.uyari = "Bir hata oluştu. Kodunuzu, Mail Adresinizi kontrol ederek tekrar deneyiniz!";
        //    }
        //    return View();
        //}
    }
}