using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VatLieuLotSan.DataBase;
using PagedList.Mvc;
using PagedList;

namespace VatLieuLotSan.Models
{
    public class SanPhamModel
    {
        DBVatLieuLotSanContext db = null;
        public SanPhamModel()
        {
            db = new DBVatLieuLotSanContext();
        }
        public IEnumerable<HANGHOA> LoadHangHoa(string LoaiHH, int soTrang, int soSanPham)
        {

            if (string.IsNullOrEmpty(LoaiHH))
            {
                return db.HANGHOAs.OrderByDescending(x => x.NGAYTAO).ToPagedList(soTrang, soSanPham);
            }
            var maHang = db.HANGHOAs.Where(x => x.MALOAI == LoaiHH).OrderByDescending(x => x.NGAYTAO).ToPagedList(soTrang, soSanPham);
            return maHang;
        }
        public IEnumerable<HANGHOA> XuatHangHoa(int soTrang, int soSanPham)
        {
            return db.HANGHOAs.OrderByDescending(x => x.NGAYTAO).ToPagedList(soTrang, soSanPham);
        }
        public HANGHOA ChiTietSanPham(string MaHang)
        {
            return db.HANGHOAs.Find(MaHang);
        }
        public List<HANGHOA> SanPhamNoiBat()
        {
            return db.HANGHOAs.Where(x => x.NOIBAT > x.NGAYTAO).OrderByDescending(x => x.NGAYTAO).Take(12).ToList();
        }
        public List<HANGHOA> SanPhamLuotXem()
        {
            return db.HANGHOAs.OrderByDescending(x => x.LUOTXEM).Take(12).ToList();
        }
        public List<HANGHOA> SanPhamSapRaMat()
        {
            return db.HANGHOAs.OrderByDescending(x => x.NGAYTAO).Take(12).ToList();
        }
        public List<LOAIHANG> LoaiHang()
        {
            return db.LOAIHANGs.ToList();
        }
        public IEnumerable<HANGHOA> BoLocSanPham(string KieuLoc, string GiaLoc)
        {
            if (string.IsNullOrEmpty(GiaLoc) || string.IsNullOrEmpty(KieuLoc))
            {
                return db.HANGHOAs.OrderByDescending(x => x.NGAYTAO).ToPagedList(1, 12);
            }
            IPagedList<HANGHOA> sp = null;
            switch (KieuLoc)
            {
                case "macdinh":
                    sp = db.HANGHOAs.OrderByDescending(x => x.NGAYTAO).ToPagedList(1, 12);
                    break;
                case "caothap":
                    sp = db.HANGHOAs.OrderBy(x => x.GIABAN).OrderBy(x => x.GIABAN).ToPagedList(1, 12);
                    break;
                case "thapcao":
                    sp = db.HANGHOAs.OrderByDescending(x => x.GIABAN).OrderByDescending(x => x.GIABAN).ToPagedList(1, 12);
                    break;
                default:
                    sp = db.HANGHOAs.OrderByDescending(x => x.NGAYTAO).ToPagedList(1, 12);
                    break;
            }
            switch (GiaLoc)
            {
                case "duoi100":
                    sp = sp.Where(x=>x.GIABAN < 100000).ToPagedList(1,12) ;
                    break;
                case "caothap":
                    sp = db.HANGHOAs.OrderBy(x => x.GIABAN).OrderBy(x => x.GIABAN).ToPagedList(1, 12);
                    break;
                case "thapcao":
                    sp = db.HANGHOAs.OrderByDescending(x => x.GIABAN).OrderByDescending(x => x.GIABAN).ToPagedList(1, 12);
                    break;
                default:
                    sp = db.HANGHOAs.OrderByDescending(x => x.NGAYTAO).ToPagedList(1, 12);
                    break;
            }
            return sp;
        }
        public IEnumerable<HANGHOA> LocGia(double min, double max)
        {
            if (min == null || max == null)
            {
                return db.HANGHOAs.OrderByDescending(x => x.NGAYTAO).ToPagedList(1, 12);
            }
            IPagedList<HANGHOA> sp = null;
            sp = db.HANGHOAs.Where(x => x.GIABAN >= min && x.GIABAN <= max).OrderByDescending(x => x.GIABAN).ToPagedList(1, 12);
            return sp;
        }
    }
}