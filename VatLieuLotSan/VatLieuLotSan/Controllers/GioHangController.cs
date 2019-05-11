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
    public class GioHangController : Controller
    {
        DBVatLieuLotSanContext db = new DBVatLieuLotSanContext();
        //private const string GioHangSession = "GioHangSession";
        // GET: GioHang
        public ActionResult GioHang()
        {
            var gio = Session[CommonConstants.GioHangSession];
            var lstItem = new List<GioHangModel>();
            if (gio != null)
            {
                lstItem = (List<GioHangModel>)gio ;
                Session[CommonConstants.GioHangSession] = lstItem;
            }
            return View(lstItem);
        }
        public List<GioHangModel> LayGioHang()
        {
            var gio = Session[CommonConstants.GioHangSession];
            var lstItem = new List<GioHangModel>();
            if (gio != null)
            {
                lstItem = (List<GioHangModel>)gio;
                Session[CommonConstants.GioHangSession] = lstItem;
            }
            return lstItem;
        }
        public ActionResult ThemVaoGioHang(string MaHang,int SoLuong)
        {
            var sp = new SanPhamModel().ChiTietSanPham(MaHang);
            var gio = Session[CommonConstants.GioHangSession];
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
                            item.ThanhTien = (SoLuong * item.SanPham.GIABAN.Value);
                        }

                    }
                }
                else
                {
                    var item = new GioHangModel();
                    item.SanPham = sp;
                    item.SoLuong = SoLuong;
                    item.ThanhTien = SoLuong * item.SanPham.GIABAN.Value;
                    lstItem.Add(item);

                }
                Session[CommonConstants.GioHangSession] = lstItem;
            }
            else
            {
                // tạo mới đối tượng giỏ hàng item 
                var item = new GioHangModel();
                item.SanPham = sp;
                item.SoLuong = SoLuong;
                item.ThanhTien = SoLuong * item.SanPham.GIABAN.Value;
                var lstItem = new List<GioHangModel>();
                lstItem.Add(item);
                //thêm ds vào Session
                Session[CommonConstants.GioHangSession] = lstItem;
            }
            return RedirectToAction("GioHang"); 
        }
        public ActionResult ThemVaoGioHang(string MaHang, int SoLuong ,string Url)
        {
            var sp = new SanPhamModel().ChiTietSanPham(MaHang);
            var gio = Session[CommonConstants.GioHangSession];
            if (gio != null)
            {
                var lstItem = (List<GioHangModel>)gio;
                if (lstItem.Exists(x => x.SanPham.MAHANG == MaHang))
                {
                    foreach (var item in lstItem)
                    {
                        if (item.SanPham.MAHANG == MaHang)
                        {
                            item.SoLuong++;
                            item.ThanhTien = (SoLuong * item.SanPham.GIABAN.Value);
                        }

                    }
                }
                else
                {
                    var item = new GioHangModel();
                    item.SanPham = sp;
                    item.SoLuong = SoLuong;
                    item.ThanhTien = SoLuong * item.SanPham.GIABAN.Value;
                    lstItem.Add(item);

                }
                Session[CommonConstants.GioHangSession] = lstItem;
            }
            else
            {
                // tạo mới đối tượng giỏ hàng item 
                var item = new GioHangModel();
                item.SanPham = sp;
                item.SoLuong = SoLuong;
                item.ThanhTien = SoLuong * item.SanPham.GIABAN.Value;
                var lstItem = new List<GioHangModel>();
                lstItem.Add(item);
                //thêm ds vào Session
                Session[CommonConstants.GioHangSession] = lstItem;
            }
            return Redirect(Url);
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
            //Kiểm tra tồn tại trong Session[CommonConstants.GioHangSession]
            GioHangModel sp = lstGioHang.Find(x => x.SanPham.MAHANG == MaHang);
            //Nếu tồn tại thì sẽ sửa số lượng
            if (sp != null)
            {
                sp.SoLuong = int.Parse(f["txtSoLuong"].ToString());
                sp.ThanhTien = sp.SoLuong * sp.SanPham.GIABAN.Value;
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
            //Kiểm tra tồn tại trong Session[CommonConstants.GioHangSession]
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
            List<GioHangModel> lstGioHang = Session[CommonConstants.GioHangSession] as List<GioHangModel>;
            if (lstGioHang != null)
            {
                TongSoLuong = lstGioHang.Sum(x => x.SoLuong);
            }
            return TongSoLuong;
        }
        private double TinhTongTien()
        {
            double TongTien = 0;
            List<GioHangModel> lstGioHang = Session[CommonConstants.GioHangSession] as List<GioHangModel>;
            if (lstGioHang != null)
            {
                TongTien = lstGioHang.Sum(x => x.ThanhTien);
            }
            return TongTien;
        }
    }
}