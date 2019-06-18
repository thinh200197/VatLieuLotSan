using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VatLieuLotSan.Models;

namespace VatLieuLotSan.Controllers
{
    public class MenuClientController : Controller
    {
        // GET: MenuClient
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DanhMuc(int Kieu)
        {
            var model = new MenuModel();
            ViewBag.DanhMuc = model.DanhMuc(1);
            return View();
        }
    }
}