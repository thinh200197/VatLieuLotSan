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
            return db.HANGHOAs.Where(x => x.MALOAI == LoaiHH).OrderByDescending(x => x.NGAYTAO).ToList();
        }
    }
}