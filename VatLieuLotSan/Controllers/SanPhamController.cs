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
            ViewBag.SPLienQuan = model.XuatHangTheoLoai(sp.MALOAI);
            return View(sp);
        }
        public ActionResult BoLocSanPham(string kieuloc, string giaban)
        {
            SanPhamModel model = new SanPhamModel();
            var sp = model.BoLocSanPham(kieuloc, giaban);
            return View("SanPham",sp);
        }
         public ActionResult TimKiem(string searchproduct)
        {
            var sp = new SanPhamModel().TimKiem(searchproduct);
            var model = new SanPhamModel();
            ViewBag.LoaiHang = model.LoaiHang();
            return View("SanPham",sp);
        }
        [HttpPost]
        public JsonResult LayDSTimKiem(string keyword)
        {
            var result = new SanPhamModel().LayDSTimKiem(keyword);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
  
    }
}