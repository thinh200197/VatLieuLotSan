using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
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
            KHACHHANG kh = (KHACHHANG) Session[CommonConstants.KhachHang];
            if (gio != null)
            {
                lstItem = (List<GioHangModel>)gio;
                Session[CommonConstants.GioHangSession] = lstItem;
            }
            if (kh != null)
            {
                ViewBag.TTKhachHang = kh;
            }
            else
                ViewBag.TTKhachHang = new KHACHHANG();
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
        //public ActionResult ThemVaoGioHang(string MaHang,int SoLuong)
        //{
        //    var sp = new SanPhamModel().ChiTietSanPham(MaHang);
        //    var gio = Session[CommonConstants.GioHangSession];
        //    if (gio != null )
        //    {
        //        var lstItem = (List<GioHangModel>)gio;
        //        if (lstItem.Exists(x=>x.SanPham.MAHANG == MaHang))
        //        {
        //            foreach (var item in lstItem)
        //            {
        //                if (item.SanPham.MAHANG == MaHang)
        //                {
        //                    item.SoLuong ++;
        //                    item.ThanhTien = (SoLuong * item.SanPham.GIABAN.Value);
        //                }

        //            }
        //        }
        //        else
        //        {
        //            var item = new GioHangModel();
        //            item.SanPham = sp;
        //            item.SoLuong = SoLuong;
        //            item.ThanhTien = SoLuong * item.SanPham.GIABAN.Value;
        //            lstItem.Add(item);

        //        }
        //        Session[CommonConstants.GioHangSession] = lstItem;
        //    }
        //    else
        //    {
        //        // tạo mới đối tượng giỏ hàng item 
        //        var item = new GioHangModel();
        //        item.SanPham = sp;
        //        item.SoLuong = SoLuong;
        //        item.ThanhTien = SoLuong * item.SanPham.GIABAN.Value;
        //        var lstItem = new List<GioHangModel>();
        //        lstItem.Add(item);
        //        //thêm ds vào Session
        //        Session[CommonConstants.GioHangSession] = lstItem;
        //    }
        //    return RedirectToAction("GioHang"); 
        //}
        public ActionResult ThemVaoGioHang(string MaHang, int SoLuong, string Url)
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
                            item.ThanhTien = (item.SoLuong * item.SanPham.GIABAN.Value);
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
            return Redirect("/gio-hang");
        }

        public JsonResult ThemSPVaoGio(string MaHang, int SoLuong ,string Url)
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
                            
                            item.ThanhTien = (item.SoLuong * item.SanPham.GIABAN.Value);
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
            return Json(new
            {
                status = true,
                sl = ((List<GioHangModel>)Session[CommonConstants.GioHangSession]).Count
            });
        }
        public JsonResult CapNhatHang(string giohangModel)
        {
            var jsonGio = new JavaScriptSerializer().Deserialize<List<GioHangModel>>(giohangModel);
            var sessionGio = (List<GioHangModel>)Session[CommonConstants.GioHangSession];

            foreach (var item in sessionGio)
            {
                var jsonItem = jsonGio.SingleOrDefault(x => x.SanPham.MAHANG == item.SanPham.MAHANG);
                if (jsonItem != null)
                {
                    item.SoLuong = jsonItem.SoLuong;
                }
            }
            Session[CommonConstants.GioHangSession] = sessionGio;
            return Json(new
            {
                status = true
            });
        }

        public JsonResult XoaHetSP()
        {
            Session[CommonConstants.GioHangSession] = null;
            return Json(new
            {
                status = true
            });
        }

        public JsonResult Xoa1SP(string MaHang)
        {
            var sessionGio = (List<GioHangModel>)Session[CommonConstants.GioHangSession];
            sessionGio.RemoveAll(a => a.SanPham.MAHANG == MaHang);
            Session[CommonConstants.GioHangSession] = sessionGio;
            return Json(new
            {
                status = true
            });
        }

        // Đặt hàng 

        public PartialViewResult DatHang()
        {
            //var kh = (KHACHHANG)Session[CommonConstants.KhachHang];
            //if (kh != null)
            //    ViewBag.KhachHang = kh;
            //else
            //    ViewBag.KhachHang = null;
            //var giohangsessionn = (List<GioHangModel>)Session[CommonConstants.GioHangSession];
            //if (giohangsessionn == null || giohangsessionn.Count == 0)
            //{
            //    ViewBag.ThongBao = "Mời bạn chọn sản phẩm để thanh toán ";
            //    return PartialView(giohangsessionn);
            //}
            return PartialView();
        }
        [HttpPost]
        public ActionResult DatHang(string tenkh, string diachi, string sdt, string email, string hinhthuc, string ghichu)
        {
            var giohangsessionn = (List<GioHangModel>)Session[CommonConstants.GioHangSession];
            if (giohangsessionn == null || giohangsessionn.Count == 0)
            {
                ViewBag.ThongBao = "Mời bạn chọn sản phẩm để thanh toán ";
                return PartialView();
            }
            var hoadon = new HOADON();
            try
            {
                //khơi tạo các biến lưu vào csdl
                // Lưu hóa đơn trước để có mã Hóa đơn mới lưu Chi tiết hóa đơn  
                // Mã hóa đơn cho tự động , lấy ví dụ mã là ngày hiện tại
                hoadon.MAHD = DateTime.Today.ToString("dd/MM/yy");
                hoadon.NGAYLAP = DateTime.Now;
                hoadon.TINHTRANG = "Chưa xữ lý";
                hoadon.TONGTIEN = (double)giohangsessionn.Sum(x => x.ThanhTien);
                hoadon.TENKHACHHANG = tenkh;
                hoadon.GIAMGIA = 0;
                db.HOADONs.Add(hoadon);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
            }
            // Lưu CT hóa đơn 
            foreach (var item in giohangsessionn)
            {
                var cthd = new CT_HOADON();
                cthd.MAHD = hoadon.MAHD;
                cthd.MAHANG = item.SanPham.MAHANG;
                cthd.SOLUONG = item.SoLuong;
                cthd.THANHTIEN = item.ThanhTien;
                db.CT_HOADON.Add(cthd);

            }
            db.SaveChanges();
            Session[CommonConstants.GioHangSession] = null;
            return RedirectToAction("HoanThanh");
        }

        // Hoàn thành
        public ActionResult HoanThanh()
        {
            return View();
        }
        
        public ActionResult CapNhatGioHang(string MaHang, int SoLuong, FormCollection f)
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
            HANGHOA hh = db.HANGHOAs.SingleOrDefault(x => x.MAHANG == MaHang);
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
            return RedirectToAction("SanPham", "SanPham");
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