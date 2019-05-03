using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VatLieuLotSan.DataBase;

namespace VatLieuLotSan.Models
{
    public class SanPhamModel
    {
        DBVatLieuLotSanContext db = null;
        public SanPhamModel()
        {
            db = new DBVatLieuLotSanContext();
        }
        public List<HANGHOA> LoadHangHoa(string LoaiHH)
        {

            if (string.IsNullOrEmpty(LoaiHH))
            {
                return db.HANGHOAs.OrderByDescending(x => x.NGAYTAO).ToList();
            }
            var maHang = db.HANGHOAs.Where(x => x.MALOAI == LoaiHH).OrderByDescending(x => x.NGAYTAO).ToList();
            return maHang;
        }
        public List<HANGHOA> XuatHangHoa()
        {
            return db.HANGHOAs.OrderByDescending(x => x.NGAYTAO).ToList(); ;
        }
        public HANGHOA ChiTietSanPham(string MaHang)
        {
            return db.HANGHOAs.Find(MaHang);
        }
    }
}