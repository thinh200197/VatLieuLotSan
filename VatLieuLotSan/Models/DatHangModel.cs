using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VatLieuLotSan.Common;
using VatLieuLotSan.DataBase;

namespace VatLieuLotSan.Models
{
    public class DatHangModel
    {
        DBVatLieuLotSanContext db = null;
        public DatHangModel()
        {
            db = new DBVatLieuLotSanContext();
        }
        public string LapMaHoaDonTuDong()
        {
            string mhd = DateTime.Now.ToString();
            return mhd;
        }

    }
}