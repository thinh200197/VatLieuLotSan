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
        public ActionResult Index(string Maloai)
        {
            var model = new SanPhamModel();
            var sanpham = model.LoadHangHoa(Maloai);
            return View(sanpham);
        }
    }
}