using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VatLieuLotSan.DataBase;
using VatLieuLotSan.Common;

namespace VatLieuLotSan.Models
{
    [Serializable]
    public class DangNhapKHModel
    {
        public string TenKH { get; set; }
        [Required]
        [Display(Name = "Tài khoản")]
        public string TenDangNhap { get; set; }
        [Required]
        [Display(Name = "Mật khẩu")]
        public string MatKhau { get; set; }
        public bool GhiNhoToi { get; set; }

    }
    public class KhachHangModel
    {
        DBVatLieuLotSanContext db = null;

        public KhachHangModel()
        {
            db = new DBVatLieuLotSanContext();
        }
        public bool KiemTraTaiKhoan(string TenTaiKhoan, string MatKhau)
        {
            KHACHHANG kh = db.KHACHHANGs.SingleOrDefault(x => x.TENDANGNHAP == TenTaiKhoan && x.MATKHAU == MatKhau);
            if (kh != null)
            {
                return true;
            }
            return false;

        }
        // đăng ký tài khoản khách hàng 
        // * Nếu tài khoản đã tồn tại thì mời chọn tên tài khoản khác -> trả về -1
        // * Nếu tài khoản Chưa tồn tại sẽ tiếp tục đăng ký , thành công-> trả về 1
        // * Nếu đăng ký không được có lỗi xảy ra  -> trả về 0
        public int DangKy(string TaiKhoan, string MatKhau, string HoTen, string SDT, string Email, string DiaChi)
        {
            
            KHACHHANG kt = db.KHACHHANGs.SingleOrDefault(x => x.TENDANGNHAP == TaiKhoan);
            if (kt != null)
            {
                return -1;
            }
            else
            {
                try
                {
                    KHACHHANG kh = new KHACHHANG();
                    kh.MAKHACHHANG = DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year.ToString("yy") + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second;
                    kh.TENKHACHHANG = HoTen;
                    kh.DIACHI = DiaChi;
                    kh.EMAIL = Email;
                    kh.SODIENTHOAI = SDT;
                    kh.TENDANGNHAP = TaiKhoan;
                    kh.MATKHAU = MatKhau;

                    db.KHACHHANGs.Add(kh);
                    db.SaveChanges();
                    return 1;
                }
                catch (Exception)
                {

                    return 0;
                }
            }
        }
        public int CapNhat(string MaKH, string HoTen, string SDT, string Email, string DiaChi)
        {
            KHACHHANG kt = db.KHACHHANGs.Find(MaKH);
            if (kt == null)
            {
                return 0;
            }
            else
            {
                try
                {
                    KHACHHANG kh = db.KHACHHANGs.Find(MaKH);
                    
                    kh.TENKHACHHANG = HoTen;
                    kh.DIACHI = DiaChi;
                    kh.EMAIL = Email;
                    kh.SODIENTHOAI = SDT;
                    
                    
                    db.SaveChanges();
                    return 1;
                }
                catch (Exception)
                {

                    return 0;
                }
            }

        }
        public KHACHHANG TT_TaiKhoan_KH(string TenTaiKhoan)
        {
            return db.KHACHHANGs.SingleOrDefault(x=>x.TENDANGNHAP == TenTaiKhoan);
        }

        public bool KT_TonTai(string  TaiKhoan)
        {
            KHACHHANG test = db.KHACHHANGs.SingleOrDefault( a => a.TENDANGNHAP == TaiKhoan);
            if (test == null)
                return false;
            else
                return true;
        }
        public bool CapNhatGioHangKhachHang(GioHangModel gh , string TenDangNhap)
        {
            try
            {
                KHACHHANG ttkh = TT_TaiKhoan_KH(TenDangNhap);
                //ghkh.TONGTIEN = ;
                db.SaveChanges();

                
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}