using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VatLieuLotSan.DataBase;
using VatLieuLotSan.Models;

namespace VatLieuLotSan.Controllers
{
    public class GioHangController : Controller
    {
        private const string GioHangSession = "GioHangSession";
        // GET: GioHang
        public ActionResult Index()
        {
            var gio = Session[GioHangSession];
            var lstItem = new List<GioHangModel>();
            if (gio != null)
            {
                lstItem = (List<GioHangModel>)gio ;
            }
            return View(lstItem);
        }
        public ActionResult ThemVaoGioHang(string MaHang,int SoLuong)
        {
            var sp = new SanPhamModel().ChiTietSanPham(MaHang);
            var gio = Session[GioHangSession];
            if (gio != null )
            {
                var lstItem = (List<GioHangModel>)gio;
                if (lstItem.Exists(x=>x.SanPham.MAHANG == MaHang))
                {
                    foreach (var item in lstItem)
                    {
                        if (item.SanPham.MAHANG == MaHang)
                        {
                            item.SoLuong ++;
                        }
                    }
                }
                else
                {
                    var item = new GioHangModel();
                    item.SanPham = sp;
                    item.SoLuong = SoLuong;
                    lstItem.Add(item);

                }
                Session[GioHangSession] = lstItem;
            }
            else
            {
                // tạo mới đối tượng giỏ hàng item 
                var item = new GioHangModel();
                item.SanPham = sp;
                item.SoLuong = SoLuong;
                var lstItem = new List<GioHangModel>();
                lstItem.Add(item);
                //thêm ds vào Session
                Session[GioHangSession] = lstItem;
            }
            return RedirectToAction("Index"); 
        }
    
    }
}