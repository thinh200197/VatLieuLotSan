using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VatLieuLotSan.Common;
using VatLieuLotSan.Models;
using PagedList;
using PagedList.Mvc;
using VatLieuLotSan.DataBase;

namespace VatLieuLotSan.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new SanPhamModel();
            ViewBag.NoiBat = model.SanPhamNoiBat();
            ViewBag.LuotXem = model.SanPhamLuotXem();
            ViewBag.ChuaRaMat = model.SanPhamSapRaMat();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult HeaderDesktop()
        {
            var model = new MenuModel();
             var menu = model.DanhMuc(1);
            return PartialView(menu);
        }

        public PartialViewResult HeaderIconCart()
        {
            List<GioHangModel> model = new List<GioHangModel>();
            KHACHHANG kh = (KHACHHANG)Session[CommonConstants.KhachHang];
            if (kh != null)
            {
                ViewBag.KH = kh;
            }

            var lstProduct = (List<GioHangModel>)Session[CommonConstants.GioHangSession];
            if (lstProduct != null)
            {
                model = lstProduct;
            }
            return PartialView(model);
        }

        public PartialViewResult Footer()
        {
            SanPhamModel sp = new SanPhamModel();
            ViewBag.lh = sp.LoaiHang();
            return PartialView();
        }
    }
}