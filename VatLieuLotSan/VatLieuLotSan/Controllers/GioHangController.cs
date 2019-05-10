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
        DBVatLieuLotSanContext db = new DBVatLieuLotSanContext();
        private const string GioHangSession = "GioHangSession";
        // GET: GioHang
        public ActionResult GioHang()
        {
            var gio = Session[GioHangSession];
            var lstItem = new List<GioHangModel>();
            if (gio != null)
            {
                lstItem = (List<GioHangModel>)gio ;
                Session[GioHangSession] = lstItem;
            }
            return View(lstItem);
        }
        public List<GioHangModel> LayGioHang()
        {
            var gio = Session[GioHangSession];
            var lstItem = new List<GioHangModel>();
            if (gio != null)
            {
                lstItem = (List<GioHangModel>)gio;
                Session[GioHangSession] = lstItem;
            }
            return lstItem;
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
            return RedirectToAction("GioHang"); 
        }
        public ActionResult CapNhatGioHang(string MaHang, int SoLuong , FormCollection f)
        {
            //Kiểm tra hàng hóa
            HANGHOA hh = db.HANGHOAs.Find(MaHang);
            // Nếu get sai thì trả về trang lỗi 404
            if (hh == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            //lấy giỏ hàng từ session
            List<GioHangModel> lstGioHang = LayGioHang();
            //Kiểm tra tồn tại trong Session[GioHangSession]
            GioHangModel sp = lstGioHang.Find(x => x.SanPham.MAHANG == MaHang);
            //Nếu tồn tại thì sẽ sửa số lượng
            if (sp != null)
            {
                sp.SanPham.SOLUONG = int.Parse(f["txtSoLuong"].ToString());
            }
            return View("GioHang");
        }
        public ActionResult XoaGioHang(string MaHang)
        {
            //Kiểm tra MaHang
            HANGHOA hh = db.HANGHOAs.SingleOrDefault(x=>x.MAHANG == MaHang);
            // Nếu get sai thì trả về trang lỗi 404
            if (hh == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            //lấy giỏ hàng từ session
            List<GioHangModel> lstGioHang = LayGioHang();
            //Kiểm tra tồn tại trong Session[GioHangSession]
            GioHangModel sp = lstGioHang.Find(x => x.SanPham.MAHANG == MaHang);
            //Nếu tồn tại thì sẽ sửa số lượng
            if (sp != null)
            {
                lstGioHang.RemoveAll(n => n.SanPham.MAHANG == MaHang);
            }
            return RedirectToAction("GioHang");
        }
        private int TinhTongSoLuong()
        {
            int TongSoLuong = 0;
            List<GioHangModel> lstGioHang = Session[GioHangSession] as List<GioHangModel>;
            if (lstGioHang != null)
            {
                TongSoLuong = lstGioHang.Sum(x => x.SoLuong);
            }
            return TongSoLuong;
        }
        private int TinhTongTien()
        {
            int TongTien = 0;
            List<GioHangModel> lstGioHang = Session[GioHangSession] as List<GioHangModel>;
            if (lstGioHang != null)
            {
                TongTien = lstGioHang.Sum(x => x.ThanhTien);
            }
            return TongTien;
        }
    }
}