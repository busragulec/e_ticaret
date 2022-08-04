using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using bgc_tropical.Models.Class;

namespace bgc_tropical.Controllers
{
    public class RegisterController : Controller
    {
        Context db = new Context();
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult signup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult signup(register r)
        {
            var bilgiler = db.registers.FirstOrDefault(x => x.mail == r.mail);
            if (bilgiler != null)
            {
                ViewBag.uyari = "Bu E-Posta adresi daha önce kullanılmış. Lütfen başka bir E-Posta adresi deneyiniz.!";
            }
            
            else 
            {
                db.registers.Add(r);
                db.SaveChanges();
                return RedirectToAction("Index", "AnaSayfa");
            }
             
            return View();
        }
    }
}


