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
        public List<HANGHOA> SanPhamNoiBat()
        {
            return db.HANGHOAs.OrderByDescending(x=>x.NOIBAT).ToList();
        }
        public List<HANGHOA> SanPhamLuotXem()
        {
            return db.HANGHOAs.OrderByDescending(x => x.LUOTXEM).ToList();
        }
        public List<HANGHOA> SanPhamSapRaMat()
        {
            return db.HANGHOAs.OrderByDescending(x => x.NGAYTAO).ToList();
        }
    }
}