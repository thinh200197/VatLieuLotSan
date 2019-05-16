using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VatLieuLotSan.Models;
using PagedList;
using PagedList.Mvc;

namespace VatLieuLotSan.Controllers
{
    public class SanPhamController : Controller
    {
        // GET: SanPham
        public ActionResult SanPham(int soTrang = 1 , int soSanPham = 12)
        {
            
            var model = new SanPhamModel();
            ViewBag.LoaiHang = model.LoaiHang();
            var sp = model.XuatHangHoa(soTrang,soSanPham);
            return View(sp);
        }
        public ActionResult XuatHangTheoLoai(string Maloai)
        {
            var model = new SanPhamModel();
            var sanpham = model.LoadHangHoa(Maloai,1,12);
            if (sanpham != null)
            {
                ViewBag.LoaiHang = model.LoaiHang();
                return View("SanPham",sanpham);
            }
            ViewBag.KhongSanPham = "Không có loại hàng này !";
            return View("SanPham");
        }
        public ActionResult ChiTietSanPham(string MaHang)
        {
            var model = new SanPhamModel();
            var sp = model.ChiTietSanPham(MaHang);
            return View(sp);
        }



    }
}