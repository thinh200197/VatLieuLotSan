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
        public ActionResult Login(DangNhapKHModel model,string duongDan)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            KhachHangModel kt = new KhachHangModel();
            if (kt.KiemTraTaiKhoan(model.TenDangNhap, model.MatKhau))
            {
                Session[CommonConstants.KhachHang] = model;
                GioHangModel gh = (GioHangModel)Session[CommonConstants.GioHangSession];

                //Thêm thông tin giỏ hàng vào giỏ hàng của tài khoản .
                KhachHangModel khmodel = new KhachHangModel();
                //khmodel.CapNhatGioHangKhachHang();

               



                return Redirect(duongDan);
            }

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
        public ActionResult DangNhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangNhap(string TaiKhoanKH ,string MatKhauKH,string GhiNho,string Link_Web)
        {
            KhachHangModel model = new KhachHangModel();
            if (model.KiemTraTaiKhoan(TaiKhoanKH,MatKhauKH))
            {
                KHACHHANG kh = new KHACHHANG();
                kh = model.TT_TaiKhoan_KH(TaiKhoanKH);
                Session[CommonConstants.KhachHang] = kh;
                return Redirect(Link_Web);
            }
            return View();
        }
        public ActionResult DangKy()
        {
            return View();
        }
    }
}