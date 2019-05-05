using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VatLieuLotSan.Models;

namespace VatLieuLotSan.Controllers
{
    public class SanPhamController : Controller
    {
        // GET: SanPham
        public ActionResult SanPham()
        {
            var model = new SanPhamModel();
            var sp = model.XuatHangHoa();
            return View(sp);
        }
        public ActionResult XuatHangTheoLoai(string Maloai)
        {
            var model = new SanPhamModel();
            var sanpham = model.LoadHangHoa(Maloai);
            if (sanpham != null)
            {
                return View("Index",sanpham);
            }
            ViewBag.KhongSanPham = "Không có loại hàng này !";
            return View("Index");
        }
        public ActionResult ChiTietSanPham(string MaHang)
        {
            var model = new SanPhamModel();
            var sp = model.ChiTietSanPham(MaHang);
            return View(sp);
        }



    }
}