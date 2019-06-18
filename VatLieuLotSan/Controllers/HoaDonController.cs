
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
    public class HoaDonController : Controller
    {
        DBVatLieuLotSanContext db = new DBVatLieuLotSanContext();
        // GET: HoaDon
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult LapHoaDon([Bind(Include = "TenKH,SDT,DiaChi,Ghichu,HinhThucThanhToan,NgayLap")] HoaDonModel dh)
        {
            KHACHHANG kh = (KHACHHANG)Session[CommonConstants.KhachHang];
            var gh = (List<GioHangModel>)Session[CommonConstants.GioHangSession];
            HOADON hd = new HOADON();

            // Hóa đợn
            hd.MAHD = DateTime.Now.ToString();
            hd.TINHTRANG = "Chưa xữ lý";
            hd.NGAYLAP = DateTime.Now;
            hd.TENKHACHHANG = dh.TenKH;
            hd.GIAMGIA= null;
            if (gh == null)
            {
                hd.TONGTIEN = 0;
            }
            else
            {
                hd.TONGTIEN = gh.Sum(x => x.ThanhTien);
            }
           
            //thêm hóa đơn vào DATA
            db.HOADONs.Add(hd);
            //db.SaveChanges();

            //Thêm Chi tiết hóa đơn
            foreach (var item in gh)
            {
                CT_HOADON cthd = new CT_HOADON();
                cthd.MAHANG = item.SanPham.MAHANG;
                cthd.SOLUONG = item.SoLuong;
                cthd.MAHD = hd.MAHD;
                db.CT_HOADON.Add(cthd);
                db.SaveChanges();
            }

            db.SaveChanges();
            return PartialView();
        }
    }
}