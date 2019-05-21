using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VatLieuLotSan.Common;
using VatLieuLotSan.DataBase;
using VatLieuLotSan.Models;

namespace VatLieuLotSan.Controllers
{
    public class KhachHangController : Controller
    {
        DBVatLieuLotSanContext db = new DBVatLieuLotSanContext();
        // GET: KhachHang
        public ActionResult KhachHang()
        {
            return View();
        }
        public ActionResult Login()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult Login(DangNhapKHModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var kh = db.KHACHHANGs.Find(model.TenDangNhap);
            if (kh!= null)
            {
                return View("Index","Home");
            }
            ViewBag.ThongBao = "Tài khoản hoặc mật khẩu không chính xác";

            return View(model);
        }
        public PartialViewResult PartialKhachHang()
        {
            //var kh = (DangNhapKHModel)Session[CommonConstants.KhachHang];
            //ViewBag.TenKH = "";
            //if (kh != null)
            //{
            //    ViewBag.TenKH = kh.TenKH ;
            //}
           
            return PartialView();
        }
        public ActionResult DangNhapKhachHang()
        {
            return PartialView();
        }
        public ActionResult DangKy()
        {
            return View();
        }
    }
}