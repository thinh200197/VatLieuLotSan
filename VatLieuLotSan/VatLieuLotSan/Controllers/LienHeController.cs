using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VatLieuLotSan.Controllers
{
    public class LienHeController : Controller
    {
        // GET: LienHe
        public ActionResult LienHe()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LienHe(string name ,string phone_number , string email,string message)
        {
            return View();
        }
    }
}