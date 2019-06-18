using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VatLieuLotSan.DataBase;

namespace VatLieuLotSan.Models
{
    public class TaiKhoanNhanVienModel
    {
        DBVatLieuLotSanContext db = null;
        public TaiKhoanNhanVienModel()
        {
            db = new DBVatLieuLotSanContext();
        }
        public bool DangNhap(string username, string password)
        {
            var result = db.NGUOIDUNGs.Count(u => u.TENDANGNHAP == username && u.MATKHAU == password);
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public NGUOIDUNG LayThongTinNguoiDung(string TenDangNhap)
        {
            return db.NGUOIDUNGs.SingleOrDefault(x=>x.TENDANGNHAP == TenDangNhap);
        }
    }
}